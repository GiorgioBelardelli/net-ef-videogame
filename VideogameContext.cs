using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_ef_videogame
{
    public class VideogameContext : DbContext
    {
        public const string STRINGA_DI_CONNESSIONE = "Data Source=localhost;Initial Catalog=Videogames;Integrated Security=True;";
        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<Software_House> Software_Houses { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Videogames;" +
                "Integrated Security=True;TrustServerCertificate=True");
            }
        
    }
}
