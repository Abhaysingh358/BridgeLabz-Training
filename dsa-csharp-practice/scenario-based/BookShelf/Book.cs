using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.BookShelf
{
    internal class Book
    {
        private string name;
        private string author;
        private string genre;
        private bool status;

        public Book(string name, string author, string genre, bool status)
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.status = status;
        }

        public string GetName() { return name; }
        public string GetAuthor() { return author; }
        public string GetGenre() { return genre; }
        public bool GetStatus() { return status; }
        public bool SetStatus(bool status)
        {
            this.status = status;
            return this.status;
        }

        public override string ToString()
        {
            return "Name Of the Book: " + name + "\n Author: " + author + "\n Genre: " + genre + "\nStatus: " + status;
        }
    }
}


