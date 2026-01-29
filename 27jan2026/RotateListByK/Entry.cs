

namespace BridgeLabz.review.RotateListByK
{
    internal class Entry
    {
        LinkedList list = new LinkedList();

        static void Main(string[] args)
        {
            Entry e = new Entry();
            e.Menu();
        }

        public void Menu()
        {
            Console.WriteLine(
                "1. Add First\n" +
                "2. Display Before Rotation\n" +
                "3. Rotate By K and Display\n" +
                "0. Exit");

            while (true)
            {
                Console.Write("\nEnter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element: ");
                        int data = int.Parse(Console.ReadLine());
                        list.AddFirst(data);
                        break;

                    case 2:
                        list.DisplayBeforRotated();
                        break;

                    case 3:
                        Console.Write("Enter K: ");
                        int k = int.Parse(Console.ReadLine());
                        list.RotateByK(k);
                        Console.WriteLine("After Rotation:");
                        list.DisplayBeforRotated();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
