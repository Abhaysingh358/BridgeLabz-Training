using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.MovieScheduleManager
{
    internal class Utility : IMovie
    {
        private Cinema[] cinemas = new Cinema[100];
        private int Count = 0;


        public void AddMovie(string title, string time)
        {
            if(Count >= cinemas.Length)
            {
                Console.WriteLine("Cinema schedule is full!");
                return;
            }

            Movie movie = new Movie();
            Cinema cinema = new Cinema();
            movie.SetTitle(title);
            cinema.SetMovie(movie);
            cinema.SetShowTime(time);


            cinemas[Count++] = cinema;
        }

       

        public void SearchMovie(string keyWord)
        {
            if (string.IsNullOrEmpty(keyWord))
            {
                Console.WriteLine("You did not enter any meaningful keywords");
                return;
            }

            keyWord = keyWord.ToLower().Trim();

            for (int i = 0; i<Count;i++)
            {
                Cinema c = cinemas[i];

                if (c.GetMovie().GetTitle().ToLower().Contains(keyWord))
                {
                    Console.WriteLine(c.GetMovie().GetTitle());
                }
            }
        }

        public void Display()
        {
            for(int i = 0; i<Count; i++)
            {
                Cinema c = cinemas[i];
                Console.WriteLine(c);
            }
        }


    }
}
