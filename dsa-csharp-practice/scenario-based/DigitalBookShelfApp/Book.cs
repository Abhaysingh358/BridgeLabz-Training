using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.DigitalBookShelfApp
{
    internal class Book
    {
        private string Title;
        private string Author;

        public string GetTitle()
        {
           return Title;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public void SetAuthor(string author)
        {
            Author = author;
        }

        public override string ToString()
        {
            return $"Book:{Title} , Author : {Author}";
        }
    }
}
