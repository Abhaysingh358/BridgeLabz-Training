using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.LibraryBookSystem
{
    
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Book b1 = new Book();

                b1.Display();
                b1.BorrowBook();
                b1.BorrowBook();
            }
        }
    }


