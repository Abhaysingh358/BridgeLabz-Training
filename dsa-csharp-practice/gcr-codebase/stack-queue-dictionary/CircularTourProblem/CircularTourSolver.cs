using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.QueueTwoStack;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.CircularTourProblem
{
    internal class CircularTourSolver
    {
        public int FindStartPoint(PetrolPump[] pumps)
        {
            int n = pumps.Length;
            QueueUsingTwoStacks queue = new QueueUsingTwoStacks();

            int start = 0;
            int currentPetrol = 0;
            int count = 0;
            int i = 0;

            while (count < n * 2)
            {
                int index = i % n;

                currentPetrol += pumps[index].Petrol - pumps[index].Distance;
                queue.Enqueue(index);

                // If petrol becomes negative, reset
                while (currentPetrol < 0 && !queue.IsEmpty())
                {
                    int removed = queue.Dequeue();
                    start = removed + 1;
                    currentPetrol = 0;
                }

                if (queue.Size() == n)
                {
                    return start;
                }

                i++;
                count++;
            }

            return -1; // No possible tour
        }
    }
}

