using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.MovieScheduleManager
{
    internal class Cinema
    {
        private Movie movie;
        private String ShowTime;

        public Movie GetMovie()
        {
            return movie;
        }

        public void SetMovie(Movie movie)
        {
            this.movie = movie;
        }

        public string GetShowTime()
        {
            return ShowTime;
        }

        public void SetShowTime(string showTime)
        {
            this.ShowTime = showTime;
        }

        public override string ToString()
        {
            return $"Movie : {movie}, ShowTime : {ShowTime}";
        }

    }
}
