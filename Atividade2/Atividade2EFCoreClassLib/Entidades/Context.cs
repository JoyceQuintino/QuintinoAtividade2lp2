using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Atividade2EFCoreClassLib.Entidades
{
    public class Context : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
        public DbSet<ContaCorrente> ContasCorrente { get; set; }
        public DbSet<ContaPoupanca> ContasPoupanca { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        public DbSet<ClienteSolicitacao> ClienteSolicitacoes { get; set; }

        private static IConfigurationRoot Configuration;

        public Context()
        {
            var configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = configurationBuilder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = (Configuration.GetConnectionString("StoreDB"));
            optionsBuilder.UseMySql(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteSolicitacao>()
                .HasKey(cs => new { cs.ClienteId, cs.SolicitacaoId });
        }
    }
}

/*
    Problemas com as entidades no migrations
    dotnet ef migrations remove
    dotnet ef database update
    dotnet ef migrations add CreateDatabase
 */