using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class SoftwareHouseManager
    {
        
        public static bool CreaSoftwareHouse(string name, string tax_id, string city, string country)
        {
            using (VideogameContext db = new VideogameContext())
            {
                try
                {

                    Software_House newSoftwareHouse = new Software_House()
                    {
                        Name = name,
                        Tax_id = tax_id,
                        City = city,
                        Country = country
                    };

                    db.Software_Houses.Add(newSoftwareHouse);
                    db.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return false;
            }
        }
    }
}
