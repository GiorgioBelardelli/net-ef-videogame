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
    [Table("software_houses")]
    [Index(nameof(Tax_id), IsUnique = true)]
    public class Software_House
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Tax_id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }

        //LISTA DI VIDEOGIOCHI [Relazione 1 a N]
        public List<Videogame> Videogames { get; set; }

        // COSTRUTTORE
        public Software_House(string name, string tax_id, string city, string country)
        {
            Name = name;
            Tax_id = tax_id;
            City = city;
            Country = country;
            Created_at = DateTime.Now;
            Updated_at = DateTime.Now;

        }

        public Software_House() { }
    }
}
