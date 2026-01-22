using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class VotingSystem
    {
        private Dictionary<string, int> voteCount;
        private List<string> voteOrder;   // LinkedHashMap simulation (insertion order)

        public VotingSystem()
        {
            voteCount = new Dictionary<string, int>();
            voteOrder = new List<string>();
        }

        public void CastVote()
        {
            Console.Write("Enter candidate name: ");
            string candidate = Console.ReadLine();

            voteOrder.Add(candidate);

            if (voteCount.ContainsKey(candidate))
                voteCount[candidate]++;
            else
                voteCount[candidate] = 1;

            Console.WriteLine("Vote casted.");
        }

        public void DisplayVoteCounts()
        {
            Console.WriteLine("\nVote Count (Dictionary):");

            if (voteCount.Count == 0)
            {
                Console.WriteLine("No votes yet.");
                return;
            }

            foreach (var kv in voteCount)
                Console.WriteLine(kv.Key + " -> " + kv.Value);
        }

        public void DisplaySortedResults()
        {
            Console.WriteLine("\nSorted Results (SortedDictionary):");

            if (voteCount.Count == 0)
            {
                Console.WriteLine("No votes yet.");
                return;
            }

            SortedDictionary<string, int> sorted = new SortedDictionary<string, int>(voteCount);

            foreach (var kv in sorted)
                Console.WriteLine(kv.Key + " -> " + kv.Value);
        }

        public void DisplayVoteOrder()
        {
            Console.WriteLine("\nVote Order (LinkedHashMap simulation):");

            if (voteOrder.Count == 0)
            {
                Console.WriteLine("No votes yet.");
                return;
            }

            for (int i = 0; i < voteOrder.Count; i++)
                Console.WriteLine((i + 1) + ". " + voteOrder[i]);
        }
    }

    class VotingSystemApp
    {
        static void Main()
        {
            VotingSystem system = new VotingSystem();

            while (true)
            {
                Console.WriteLine("\nVoting System Menu");
                Console.WriteLine("1. Cast Vote");
                Console.WriteLine("2. Display Vote Counts");
                Console.WriteLine("3. Display Sorted Results");
                Console.WriteLine("4. Display Vote Order");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        system.CastVote();
                        break;
                    case 2:
                        system.DisplayVoteCounts();
                        break;
                    case 3:
                        system.DisplaySortedResults();
                        break;
                    case 4:
                        system.DisplayVoteOrder();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

}
