using Brasileirao_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Brasileirao_App.Data
{
    public class BrasileiraoContext : DbContext
    {
        public BrasileiraoContext(DbContextOptions<BrasileiraoContext> options) : base(options)
        {
            
        }

        public DbSet<Jogador> Jogadores { get; set;}
        public DbSet<Time> Times { get; set;}
        public DbSet<Estadio> Estadios { get; set;}
        public DbSet<Posicao> Posicoes { get; set;}
        public DbSet<UF> UFs { get; set;}

    }
}
