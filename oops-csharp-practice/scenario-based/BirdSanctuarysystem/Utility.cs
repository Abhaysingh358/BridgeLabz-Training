using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.BirdSanctuarysystem
{
    internal class Utility
    {
        Bird[] Sanctury = new Bird[]
        {
            new Eagle("Eagle", false, 95.5, "06-01-2026"),
            new Sparrow("Sparrow", true, 12.0, "05-01-2026"),
            new Duck("Duck", false, 45.0, "04-01-2026"),
            new Penguin("Penguin", false, 35.0, "06-01-2026"),
            new Seagull("Seagull", true, 50.0, "03-01-2026")
        };

        public void Display()
        {
            for (int i = 0; i < Sanctury.Length; i++)
            {
               
                if (Sanctury[i] is IFlyable f && Sanctury[i] is ISwimmable s)
                {
                    f.Fly();
                    s.Swim();
                }

                else if (Sanctury[i] is IFlyable flyable)
                {
                    flyable.Fly();
                }

                else if (Sanctury[i] is ISwimmable swim)
                {
                    swim.Swim();
                }
                 Console.WriteLine(Sanctury[i]);
                Console.WriteLine();
            }

        }

        

       
    }
}
