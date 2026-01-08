using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.MovieManagementSystem
{
    internal class Movie
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;

        public Movie Next;
        public Movie Prev;

        public Movie(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }
}
