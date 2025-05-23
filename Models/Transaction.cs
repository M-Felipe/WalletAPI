﻿namespace WalletAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }

        // Relacionamentos
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}