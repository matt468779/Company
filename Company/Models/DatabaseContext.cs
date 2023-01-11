using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("server=localhost;port=3306;database=company;uid=root;password=root;") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemQuantity> ItemQuantities { get; set; }
        public DbSet<MaterialReceiving> MaterialRecievings { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Unit> units { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(u => u.name)
                .HasColumnName("name");
        }



    }
}
