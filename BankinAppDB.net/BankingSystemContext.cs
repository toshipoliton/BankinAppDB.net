using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BankinAppDB.net
{
    public partial class BankingSystemContext : DbContext
    {
        public BankingSystemContext()
            : base("name=BankingSystemContext")
        {
        }

        public virtual DbSet<CheckingsAccount> CheckingsAccounts { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<SavingsAccount> SavingsAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheckingsAccount>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.CheckingsAccounts)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.SavingsAccounts)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SavingsAccount>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SavingsAccount>()
                .Property(e => e.Interest)
                .HasPrecision(19, 4);
        }
    }
}
