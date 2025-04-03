using Api_Jogos_Isaac.Domains;
using Microsoft.EntityFrameworkCore;

namespace Api_Jogos_Isaac.Context
{
    public class Jogos_Context : DbContext
    {
        public Jogos_Context()
        {
        }
        public Jogos_Context(DbContextOptions<Jogos_Context> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Jogos> Jogos { get; set; }
      
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server =NOTE39-S28\\SQLEXPRESS; Database = Jogos; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }

        }


    }
}
    
