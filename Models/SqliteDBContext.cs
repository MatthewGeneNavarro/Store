using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Store.Models
{
    class SqliteDBContext : DbContext
    {
        // DbSet<T> represents a table 
        public DbSet<Product> Items { get; set; }
        public DbSet<ProductQuantity> ItemsInCart { get; set; }
        // checkout page?


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=C:\Users\mgnavarro\Desktop\Final Project c#\Store\db.sqlite");
            base.OnConfiguring(options);
        }

    }
}
