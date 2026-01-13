using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.MovieScheduleManager
{
    internal class Movie
    {
        private string Title;
        //private string MovieHours;

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string title)
        {
            this.Title = title;
        }

        //public string GetMovieHours()
        //{
        //    return MovieHours;
        //}

        //public void SetMovieHours(string movieHours)
        //{
        //    this.MovieHours = movieHours;
        //}


        public override string ToString()
        {
            return $"Movie : {Title} ";
        }

    }
}
