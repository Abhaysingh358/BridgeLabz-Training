using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.BookShelf
{
    internal interface IBook
    {
        void AddBook();
        void DeleteBook();
        void DisplayByGenre();
        void UpdateStatus();

    }
}
