using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AmbulanceRoute
{
    internal class AmbulanceRouteUtility : IAmbulanceRouteUtility
    {
        private HospitalCircularList hospitalList = new HospitalCircularList();

        // Take input inside utility and add node
        public void AddHospitalUnit()
        {
            Console.Write("Enter Unit Id: ");
            string unitId = Console.ReadLine();

            Console.Write("Enter Unit Name: ");
            string unitName = Console.ReadLine();

            HospitalUnit unit = new HospitalUnit(unitId, unitName);
            hospitalList.AddUnit(unit);

            Console.WriteLine("Hospital unit added successfully.");
        }

        // Find nearest available unit
        public void RedirectPatient()
        {
            HospitalUnit head = hospitalList.GetHead();

            if (head == null)
            {
                Console.WriteLine("No hospital units available.");
                return;
            }

            HospitalUnit current = head;

            do
            {
                if (current.IsAvailable())
                {
                    Console.WriteLine("Patient redirected to: " + current.GetUnitName());
                    return;
                }

                current = current.GetNextUnit();

            } while (current != head);

            Console.WriteLine("All units are under maintenance.");
        }

        // Mark unit under maintenance (input inside method)
        public void MarkUnderMaintenance()
        {
            Console.Write("Enter Unit Id to mark maintenance: ");
            string unitId = Console.ReadLine();

            HospitalUnit head = hospitalList.GetHead();
            if (head == null) return;

            HospitalUnit temp = head;

            do
            {
                if (temp.GetUnitId() == unitId)
                {
                    temp.MarkUnderMaintenance();
                    Console.WriteLine("Unit marked under maintenance.");
                    return;
                }

                temp = temp.GetNextUnit();

            } while (temp != head);
        }

        // Remove unit (input inside method)
        public void RemoveHospitalUnit()
        {
            Console.Write("Enter Unit Id to remove: ");
            string unitId = Console.ReadLine();

            HospitalUnit head = hospitalList.GetHead();
            if (head == null) return;

            HospitalUnit temp = head;

            do
            {
                if (temp.GetUnitId() == unitId)
                {
                    hospitalList.RemoveUnit(temp);
                    Console.WriteLine("Unit removed.");
                    return;
                }

                temp = temp.GetNextUnit();

            } while (temp != head);
        }

        // Display route
        public void DisplayRoute()
        {
            hospitalList.Display();
        }
    }
}

