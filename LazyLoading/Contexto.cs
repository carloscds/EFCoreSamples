using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Proxies;

namespace LazyLoading
{
    public class Contexto : DbContext
    {
        public DbSet<Customers> Customers {get; set;}
        public DbSet<Orders> Orders {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = new SqlConnectionStringBuilder()
            {
                DataSource = "(local)",
                InitialCatalog = "NorthWind",
                IntegratedSecurity = true
            };
            optionsBuilder.UseSqlServer(conexao.ConnectionString);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}