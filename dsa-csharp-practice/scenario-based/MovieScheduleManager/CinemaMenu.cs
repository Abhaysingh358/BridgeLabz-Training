using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.MovieScheduleManager
{
    internal class CinemaMenu
    {
        private readonly int choice;
        private CinemaUtility CinemaTime = new CinemaUtility();

        public void Start()
        {

            do
            {
                Console.WriteLine("\nSelsect the options");
                Console.WriteLine("1.Add Movie");
                Console.WriteLine("2.Search Movie");
                Console.WriteLine("3.Display All Movies");
                Console.WriteLine("4.Exit");

                Console.WriteLine("Enter the choice in number");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                      
                        CinemaTime.AddMovie();
                        break;

                    case 2:
                        
                        CinemaTime.SearchMovie();
                        break;

                    case 3:
                        CinemaTime.Display();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice"); break;

                }
            }
            while (choice != 4);
         }   
    }
}
