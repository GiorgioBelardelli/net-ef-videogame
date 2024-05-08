using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class VideogameManager
    {
        
        public static bool CreaVideogioco(string name, string overview, DateTime releaseDate, long software_house_id)
        {
            using (VideogameContext db = new VideogameContext())
            {
                try
                {

                    Videogame newVideogame = new Videogame()
                    {
                        Name = name,
                        Overview= overview,
                        Release_date = releaseDate,
                        SoftwareHouseid = software_house_id
                    };

                    db.Videogames.Add(newVideogame);
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
