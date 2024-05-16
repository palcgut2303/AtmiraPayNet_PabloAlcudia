using AtmitaPayNet.API.Models;
using Microsoft.AspNetCore.Identity;
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


            List<IdentityRole> roles = new List<IdentityRole>
        {
            new IdentityRole
            { Name = "Empleado", NormalizedName = "EMPLEADO" }
        };
            modelBuilder.Entity<IdentityRole>().HasData(roles);

        }

        public DbSet<PaymentLetter> PaymentLetters { get; set; }

    }
}
