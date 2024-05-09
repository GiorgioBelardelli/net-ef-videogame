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
    public class SoftwareHouseManager
    {
        
        public static bool CreaSoftwareHouse(Software_House softwareHouse)
        {
            using (VideogameContext db = new VideogameContext())
                try
                {
                    db.Software_Houses.Add(softwareHouse);
                    db.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
        }
    }
}
