using Microsoft.EntityFrameworkCore;

namespace net_ef_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
                

            try
            {
                bool continua = true;

                while (continua)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Inserire una nuova Software House");
                    Console.WriteLine("2. Inserire un nuovo videogioco");
                    Console.WriteLine("3. Ricercare un videogioco per ID");
                    Console.WriteLine("4. Ricercare tutti i videogiochi aventi il nome contenente una determinata stringa");
                    Console.WriteLine("5. Cancellare un videogioco");
                    Console.WriteLine("6. Chiudere il programma");
                    Console.Write("Seleziona un'opzione: ");
                    string scelta = Console.ReadLine();

                    switch (scelta)
                    {
                        case "1":
                            Console.Write("Inserisci il nome della Software House: ");
                            string nome = Console.ReadLine();

                            Console.Write("Inserisci il tax id della Software House: ");
                            string tax_id = Console.ReadLine();

                            Console.Write("Inserisci la cittá della Software House: ");
                            string city = Console.ReadLine();

                            Console.Write("Inserisci lo stato della Software House: ");
                            string country = Console.ReadLine();

                            //Software_House softwareHouse = new Software_House(nome, tax_id, city, country);

                            SoftwareHouseManager.CreaSoftwareHouse(nome, tax_id, city, country);
                            break;

                        /*case "2":
                            Console.Write("Inserisci il nome del videogioco: ");
                            string nomeVidegioco = Console.ReadLine();

                            Console.Write("Inserisci l'overview del videogioco: ");
                            string overview = Console.ReadLine();

                            Console.Write("Inserisci la data di rilascio del videogioco (YYYY-MM-DD): ");
                            string releaseDateStr = Console.ReadLine();
                            DateTime releaseDate = DateTime.Parse(releaseDateStr);

                            Console.Write("Inserisci la Software House id: ");
                            int shId = int.Parse(Console.ReadLine());

                            Videogame nuovoVideogioco = new(nomeVidegioco, overview, releaseDate, shId);

                            managerVideogame.InserisciVideogioco(nuovoVideogioco);
                            break;

                        case "3":
                            Console.Write("Inserisci il codice ID del videogioco: ");
                            int videogameId = int.Parse(Console.ReadLine());

                            managerVideogame.GetVideogameById(videogameId);
                            break;

                        case "4":
                            Console.Write("Inserisci una stringa di ricerca per il nome del videogioco: ");
                            string userSearch = Console.ReadLine();

                            managerVideogame.SearchVideogamesByName(userSearch);
                            break;

                        case "5":
                            Console.Write("Inserisci il codice ID del videogioco che vuoi cancellare: ");
                            long videogameIdDelete = long.Parse(Console.ReadLine());

                            managerVideogame.DeleteVideoGameById(videogameIdDelete);
                            break;

                        case "6":
                            continua = false;
                            Console.WriteLine("Programma chiuso.");
                            break;
                        default:
                            Console.WriteLine("Scelta non valida. Riprova.");
                            break;*/
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
