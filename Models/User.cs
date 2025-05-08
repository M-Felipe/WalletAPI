namespace WalletAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public decimal Balance { get; set; }

        // Relacionamentos
        public ICollection<Transaction> SentTransactions { get; set; } // Transações enviadas
        public ICollection<Transaction> ReceivedTransactions { get; set; } // Transações recebidas
    }
}