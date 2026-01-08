using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.MovieManagementSystem
{
    internal class MovieUtility
    {
        public Movie CreateMovie()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Director: ");
            string director = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Rating: ");
            double rating = double.Parse(Console.ReadLine());

            return new Movie(title, director, year, rating);
        }

        public void Print(Movie movie)
        {
            Console.WriteLine($"Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}, Rating: {movie.Rating}");
        }
    }
}
