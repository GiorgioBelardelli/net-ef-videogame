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
    public class VideogameManager
    {

        public static bool CreaVideogioco(Videogame videogame)
        {
            using (VideogameContext db = new VideogameContext())
            {
                try
                {

                    db.Videogames.Add(videogame);
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

        public static Videogame GetVideogameById(long id)
        {
            try
            {
                using VideogameContext db = new VideogameContext();
                return db.Videogames.Where(x => x.Id == id).Include(x => x.SoftwareHouse).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public static List<Videogame> GetVideogamesByName(string name)
        {
            try
            {
                using VideogameContext db = new VideogameContext();
                return db.Videogames.Where(x => x.Name.Contains(name)).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static void DeleteVideogameById(long id)
        {
                var videogame = GetVideogameById(id);
                if (videogame == null) 
                {
                    return;
                }
                using VideogameContext db = new VideogameContext();
                db.Remove(videogame);
                db.SaveChanges();   
        }
    }
}
