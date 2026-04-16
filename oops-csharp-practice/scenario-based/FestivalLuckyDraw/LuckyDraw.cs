using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.FestivalLuckyDraw
{
    internal class LuckyDraw
    {
        int num;

        public void Draw()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("You are a Winner");
            }
            else
            {
                Console.WriteLine("loosing is a part of learning");
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Lucky Draw Game");
                Console.WriteLine("1.To Draw a Number");
                Console.WriteLine("2.Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Draw();
                        break;

                    case 2:
                        Console.WriteLine("Thank You for Visiting");
                        return;

                    default:
                        Console.WriteLine("Invalid Options");
                        break;

                }
            }

        }
    }
}

