using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Seesion1.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.id)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.name)
                .IsFixedLength();
        }

        public System.Data.Entity.DbSet<Seesion1.Models.Person> Person { get; set; }
    }
}
