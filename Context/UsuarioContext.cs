using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeuProjetoCRUD.Entities;

namespace MeuProjetoCRUD.Context
{
    public class UsuarioContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public UsuarioContext(DbContextOptions<UsuarioContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Contato> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConexaoPadrao"));
        }
    }
}