using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AmbulanceRoute
{
    internal class HospitalCircularList
    {
        private HospitalUnit head;

        // Insert new unit into circular list
        public void AddUnit(HospitalUnit newUnit)
        {
            if (head == null)
            {
                head = newUnit;
                head.SetNextUnit(head);
                return;
            }

            HospitalUnit temp = head;

            while (temp.GetNextUnit() != head)
            {
                temp = temp.GetNextUnit();
            }

            temp.SetNextUnit(newUnit);
            newUnit.SetNextUnit(head);
        }

        // Remove a unit from circular list
        public void RemoveUnit(HospitalUnit target)
        {
            if (head == null || target == null)
                return;

            HospitalUnit current = head;
            HospitalUnit previous = null;

            do
            {
                if (current == target)
                {
                    if (previous != null)
                    {
                        previous.SetNextUnit(current.GetNextUnit());
                    }
                    else
                    {
                        HospitalUnit last = head;

                        while (last.GetNextUnit() != head)
                        {
                            last = last.GetNextUnit();
                        }

                        if (current == last)
                        {
                            head = null;
                        }
                        else
                        {
                            last.SetNextUnit(current.GetNextUnit());
                            head = current.GetNextUnit();
                        }
                    }
                    return;
                }

                previous = current;
                current = current.GetNextUnit();

            } while (current != head);
        }

        // Get head (for traversal in utility)
        public HospitalUnit GetHead()
        {
            return head;
        }

        // Display circular list
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No hospital units in list.");
                return;
            }

            HospitalUnit temp = head;

            do
            {
                Console.Write($"[{temp.GetUnitName()}] -> ");
                temp = temp.GetNextUnit();
            }
            while (temp != head);

            Console.WriteLine("(circular)");
        }
    }
}
