using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    using System;
    using System.Collections;

    class ReverseArrayList
    {
        static void Reverse(ArrayList list)
        {
            int i = 0, j = list.Count - 1;

            while (i < j)
            {
                object temp = list[i];
                list[i] = list[j];
                list[j] = temp;
                i++;
                j--;
            }
        }

        static void Main()
        {
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            Reverse(list);

            foreach (var x in list) Console.Write(x + " ");
        }
    }

}
