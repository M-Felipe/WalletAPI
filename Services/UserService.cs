using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using WalletAPI.Data;
using WalletAPI.Models;

namespace WalletAPI.Services
{
    public class UserService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public User GetUserByUsername(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
                throw new InvalidOperationException("Usuario não encontrado.");
            return user;
        }

        public User GetUserById(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user == null)
                throw new InvalidOperationException("Usuario não encontrado.");
            return user;
        }

        public bool UserExists(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}