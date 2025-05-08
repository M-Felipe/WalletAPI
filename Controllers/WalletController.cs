using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WalletAPI.DTOs;
using WalletAPI.Services;

namespace WalletAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController(WalletService walletService) : ControllerBase
    {
        private readonly WalletService _walletService = walletService;

        // Consultar saldo
        [HttpGet("balance")]
        public IActionResult GetBalance()
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            try
            {
                var balance = _walletService.GetBalance(userId);
                return Ok(new { Balance = balance });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Adicionar saldo
        [HttpPost("add-balance")]
        public IActionResult AddBalance([FromBody] AddBalanceDto dto)
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            try
            {
                if (dto.Amount <= 0)
                    return BadRequest("Valor deve ser maior que zero.");
                _walletService.AddBalance(userId, dto.Amount);
                return Ok(new { Message = "Valor adicionado com sucesso." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}