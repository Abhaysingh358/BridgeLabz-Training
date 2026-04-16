using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Library_Management_System
{
    internal abstract class LibraryItem
    {
        // basic item details
        private int itemId;
        private string title;
        private string author;

        public int ItemId { get { return itemId; } }
        public string Title { get { return title; } }
        public string Author { get { return author; } }

        // setters for encapsulation
        public void SetItemId(int id) { itemId = id; }
        public void SetTitle(string t) { title = t; }
        public void SetAuthor(string a) { author = a; }

        // common method
        public void GetItemDetails()
        {
            Console.WriteLine(title + " by " + author);
        }

        // loan duration differs
        public abstract int GetLoanDuration();
    }
}
