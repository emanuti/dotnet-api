using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infraestructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) {}

        public DbSet<ContaCorrente> ContasCorrentes { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }


        public override int SaveChanges()
        {   
            return base.SaveChanges();
        }
    }
}