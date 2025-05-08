using System.Security.Claims;
using WalletAPI.Data;
using WalletAPI.Models;

namespace WalletAPI.Services
{
    public class WalletService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        // Consultar saldo do usuário
        public decimal GetBalance(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
                throw new InvalidOperationException("Usuario não encontrado.");
            return user.Balance;
        }

        // Adicionar saldo ao usuário
        public void AddBalance(int userId, decimal amount)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
                throw new InvalidOperationException("Usuario não encontrado.");

            user.Balance += amount;
            _context.SaveChanges();
        }

        // Realizar transferência entre usuários
        public void Transfer(int senderId, int receiverId, decimal amount)
        {
            var sender = _context.Users.Find(senderId);
            var receiver = _context.Users.Find(receiverId);

            if (sender == null || receiver == null)
                throw new InvalidOperationException("Recebedor ou transferidor não encontrados.");

            if (sender.Balance < amount)
                throw new InvalidOperationException("Saldo insuficiente.");

            sender.Balance -= amount;
            receiver.Balance += amount;

            _context.SaveChanges();
        }
    }
}