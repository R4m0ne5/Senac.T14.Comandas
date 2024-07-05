using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas
{
    // classe que representa o banco de dados
    public class AppDbContext : DbContext
    {
        // propiedade que representa a tabela usuarios
        public DbSet<Usuario> Usuarios { get; set; }
            // métodos que configura informando para o EF que o banco  será SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }
}
