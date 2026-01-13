using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.MovieScheduleManager
{
    internal interface IMovie
    {
        public void AddMovie(string title ,  string time);
        public void SearchMovie(string keyWord);

        public void Display();
    }
}
