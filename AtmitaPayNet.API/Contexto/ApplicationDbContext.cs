using AtmitaPayNet.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace AtmitaPayNet.API.Contexto
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PaymentLetter>().OwnsOne(p => p.Address, p => p.ToJson());

            modelBuilder.Entity<BankAccount>()
                .Property(v => v.IBANBankAccount)
                .HasConversion(
                       v => v.IBANBankAccount,
                       v => new IBAN(v)
                       
                       );

            modelBuilder.Entity<PaymentLetter>()
               .HasOne(p => p.OriginBank)
               .WithMany(b => b.OriginPayment)
               .HasForeignKey(p => p.OriginBankId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PaymentLetter>()
                    .HasOne(p => p.DestinationBank)
                    .WithMany(b => b.DestinationPayment)
                    .HasForeignKey(p => p.DestinationBankId)
                    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PaymentLetter>()
                .HasOne(p => p.InterBank)
                .WithMany(b => b.InterPayment)
                .HasForeignKey(p => p.InterBankId)
                .OnDelete(DeleteBehavior.NoAction);


        }

        public DbSet<PaymentLetter> PaymentLetters { get; set; }

    }
}
