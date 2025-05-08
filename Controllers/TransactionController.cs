using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WalletAPI.Data;
using WalletAPI.DTOs;
using WalletAPI.Models;
using WalletAPI.Services;

namespace WalletAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController(TransactionService transactionService, UserService userService) : ControllerBase
    {
        private readonly TransactionService _transactionService = transactionService;
        private readonly UserService _userService = userService;

        [HttpPost("transfer")]
        public IActionResult Transfer([FromBody] TransferDto dto)
        {
            var senderId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            if(senderId == dto.ReceiverId)
                return BadRequest("Você não pode transferir para si mesmo.");

            var sender = _userService.GetUserById(senderId);
            var receiver = _userService.GetUserById(dto.ReceiverId);

            if (sender == null || receiver == null)
                return NotFound("Usuario não encontrado.");

            if (sender.Balance < dto.Amount)
                return BadRequest("Saldo insuficiente.");

            if (dto.Amount <= 0)
                return BadRequest("Valor de transferencia deve ser maior que zero.");

            sender.Balance -= dto.Amount;
            receiver.Balance += dto.Amount;

            var transaction = new Transaction
            {
                SenderId = senderId,
                ReceiverId = dto.ReceiverId,
                Amount = dto.Amount,
                Timestamp = DateTime.UtcNow
            };

            _transactionService.AddTransaction(transaction);

            return Ok(new { Message = "Transferencia realizada com sucesso.", NewBalance = sender.Balance });
        }

        [HttpGet("history")]
        public IActionResult GetTransactionHistory([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate)
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            var transactions = _transactionService.GetTransactionHistory(userId, startDate, endDate);

            return Ok(transactions);
        }
    }
}