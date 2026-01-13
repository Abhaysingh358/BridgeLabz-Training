using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.DigitalBookShelfApp
{
    internal interface IBook
    {
        public void AddBook();
        public void SortBooksAlphabetically();

        public void SearchByAuthor();
       public void DisplayAllBooks();

    }
}
