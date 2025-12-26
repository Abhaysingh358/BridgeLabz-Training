using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MissingNum
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter size");
        int size = int.Parse(Console.ReadLine());

        int [] arr = new int[size];

        for(int i = 0; i <size; i++)
        {
            Console.WriteLine("enter the " + (i+1) + " number");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int sum = 0;
        int max = Int32.MinValue;

        for(int i = 0; i< size; i++)
        {
            sum+=arr[i];
            max = Math.Max(arr[i] , max);
        }

        int n = arr[size-1];
        int n1 = n+1;
        
        // formula of natural sum
        int natsum  = n * n1  /2;

        int num = natsum - sum;

        Console.WriteLine(num);

       

        

    }
}