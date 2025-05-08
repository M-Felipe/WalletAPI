using Microsoft.EntityFrameworkCore;
using WalletAPI.Models;

namespace WalletAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da tabela Users
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(u => u.Id); // Define a chave primária
                entity.Property(u => u.Username).IsRequired().HasMaxLength(50);
                entity.Property(u => u.PasswordHash).IsRequired();
                entity.Property(u => u.Balance).HasColumnType("decimal(18,2)").HasDefaultValue(0);
            });

            // Configuração da tabela Transactions
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transactions");
                entity.HasKey(t => t.Id); // Define a chave primária
                entity.Property(t => t.Amount).HasColumnType("decimal(18,2)").IsRequired();
                entity.Property(t => t.Timestamp).HasDefaultValueSql("CURRENT_TIMESTAMP");

                // Relacionamentos
                entity.HasOne(t => t.Sender)
                      .WithMany()
                      .HasForeignKey(t => t.SenderId)
                      .OnDelete(DeleteBehavior.Restrict); // Evita exclusão em cascata

                entity.HasOne(t => t.Receiver)
                      .WithMany()
                      .HasForeignKey(t => t.ReceiverId)
                      .OnDelete(DeleteBehavior.Restrict); // Evita exclusão em cascata
            });

            // Dados iniciais (opcional)
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "user1", PasswordHash = BCrypt.Net.BCrypt.HashPassword("password1"), Balance = 1000 },
                new User { Id = 2, Username = "user2", PasswordHash = BCrypt.Net.BCrypt.HashPassword("password2"), Balance = 500 }
            );
        }
    }
}