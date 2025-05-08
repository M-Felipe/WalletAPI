using System.Security.Claims;
using WalletAPI.Data;
using WalletAPI.Models;

namespace WalletAPI.Services
{
    public class TransactionService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public IEnumerable<Transaction> GetTransactionHistory(int userId, DateTime? startDate, DateTime? endDate)
        {
            var query = _context.Transactions.AsQueryable();
            if (startDate.HasValue)
                query = query.Where(t => t.Timestamp >= startDate.Value);
            if (endDate.HasValue)
                query = query.Where(t => t.Timestamp <= endDate.Value);
            return query.Where(t => t.SenderId == userId || t.ReceiverId == userId).ToList();
        }

        public void AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
    }
}