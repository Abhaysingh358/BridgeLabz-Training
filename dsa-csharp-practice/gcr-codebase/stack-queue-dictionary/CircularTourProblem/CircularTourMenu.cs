using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.CircularTourProblem
{
    internal class CircularTourMenu
    {
        public void Run()
        {
            Console.Write("Enter number of petrol pumps: ");
            int n = Convert.ToInt32(Console.ReadLine());

            PetrolPump[] pumps = new PetrolPump[n];

            Console.WriteLine("Enter the distance like : 50 87");
            Console.WriteLine("Enter petrol and distance for each pump:");
            for (int i = 0; i < n; i++)
            { 
                Console.Write($"Pump {i} (petrol distance): ");
                string[] input = Console.ReadLine().Split(' ');
                
                pumps[i] = new PetrolPump(
                    Convert.ToInt32(input[0]),
                    Convert.ToInt32(input[1])
                );
            }

            CircularTourSolver solver = new CircularTourSolver();
            int start = solver.FindStartPoint(pumps);

            if (start == -1)
                Console.WriteLine("No possible circular tour.");
            else
                Console.WriteLine("Start at petrol pump index: " + start);
        }
    }
}
