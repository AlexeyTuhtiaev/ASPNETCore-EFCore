using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WorkWithEFCoreApp.Entities;

namespace WorkWithEFCoreApp
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-L6BKAANE\MSSQL2014DEVEDIT; Database=EfCoreDB; Trusted_Connection=True;");
        }
    }
}
