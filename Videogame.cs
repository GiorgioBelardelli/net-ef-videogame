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
    [Table("videogames")]
    public class Videogame
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public DateTime Release_date { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }

        //Software House di riferimento con chiave esterna [Relazione 1 a N]
        public long SoftwareHouseid { get; set; }
        public Software_House SoftwareHouse { get; set; }


        // COSTRUTTORE
        public Videogame(string name, string overview, DateTime releaseDate, long software_house_id)
        {
            Name = name;
            Overview = overview;
            Release_date = releaseDate;
            Created_at = DateTime.Now;
            Updated_at = DateTime.Now;
            SoftwareHouseid = software_house_id;
        }

        public Videogame() { }
    }
}
