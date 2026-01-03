using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.single_inheritence.LibraryManagement
{
    internal class Book
    {
        protected string Title;
        protected int PublicationYear;
        public Book(string title, int publicationYear)
        {
            this.Title = title;
            this.PublicationYear = publicationYear;
        }


        public override string ToString()
        {
            return $"Title : {Title} , Publication Year : {PublicationYear}";
        }
    }
}
