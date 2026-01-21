using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class Policy
    {
        public string PolicyNumber { get; private set; }
        public string CustomerName { get; private set; }
        public string CoverageType { get; private set; }
        public DateTime ExpiryDate { get; private set; }

        public Policy(string policyNumber, string customerName, string coverageType, DateTime expiryDate)
        {
            PolicyNumber = policyNumber;
            CustomerName = customerName;
            CoverageType = coverageType;
            ExpiryDate = expiryDate;
        }

        public override bool Equals(object obj)
        {
            if (obj is Policy p)
                return this.PolicyNumber == p.PolicyNumber;
            return false;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        public override string ToString()
        {
            return "PolicyNo: " + PolicyNumber +
                   ", Name: " + CustomerName +
                   ", Coverage: " + CoverageType +
                   ", Expiry: " + ExpiryDate.ToString("dd-MM-yyyy");
        }
    }

    class PolicyExpiryComparer : IComparer<Policy>
    {
        public int Compare(Policy a, Policy b)
        {
            int cmp = a.ExpiryDate.CompareTo(b.ExpiryDate);
            if (cmp == 0)
                return a.PolicyNumber.CompareTo(b.PolicyNumber);
            return cmp;
        }
    }

    class InsurancePolicyManagementSystem
    {
        private HashSet<Policy> policyHashSet;
        private List<Policy> insertionOrderList;      // LinkedHashSet simulation
        private SortedSet<Policy> policySortedSet;    // TreeSet simulation

        public InsurancePolicyManagementSystem()
        {
            policyHashSet = new HashSet<Policy>();
            insertionOrderList = new List<Policy>();
            policySortedSet = new SortedSet<Policy>(new PolicyExpiryComparer());
        }

        public void AddPolicy()
        {
            Console.Write("Enter Policy Number: ");
            string policyNo = Console.ReadLine();

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Coverage Type (Health/Life/Vehicle/Home): ");
            string coverage = Console.ReadLine();

            Console.Write("Enter Expiry Date (dd-MM-yyyy): ");
            DateTime expiry = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            Policy p = new Policy(policyNo, name, coverage, expiry);

            if (policyHashSet.Add(p))
            {
                insertionOrderList.Add(p);
                policySortedSet.Add(p);
                Console.WriteLine("Policy added successfully.");
            }
            else
            {
                Console.WriteLine("Duplicate policy found (Policy Number already exists).");
            }
        }

        public void ShowAllUniquePolicies()
        {
            Console.WriteLine("\nAll Unique Policies:");
            if (policyHashSet.Count == 0)
            {
                Console.WriteLine("No policies found.");
                return;
            }

            foreach (var p in policyHashSet)
                Console.WriteLine(p);
        }

        public void ShowPoliciesInsertionOrder()
        {
            Console.WriteLine("\nPolicies in Insertion Order:");
            if (insertionOrderList.Count == 0)
            {
                Console.WriteLine("No policies found.");
                return;
            }

            foreach (var p in insertionOrderList)
                Console.WriteLine(p);
        }

        public void ShowPoliciesSortedByExpiry()
        {
            Console.WriteLine("\nPolicies Sorted By Expiry Date:");
            if (policySortedSet.Count == 0)
            {
                Console.WriteLine("No policies found.");
                return;
            }

            foreach (var p in policySortedSet)
                Console.WriteLine(p);
        }

        public void ShowExpiringSoonPolicies()
        {
            Console.WriteLine("\nPolicies Expiring Soon (Next 30 days):");

            DateTime today = DateTime.Today;
            DateTime limit = today.AddDays(30);

            bool found = false;

            foreach (var p in policySortedSet)
            {
                if (p.ExpiryDate >= today && p.ExpiryDate <= limit)
                {
                    Console.WriteLine(p);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No policies expiring within next 30 days.");
        }

        public void ShowPoliciesByCoverageType()
        {
            Console.Write("\nEnter Coverage Type to search: ");
            string type = Console.ReadLine();

            Console.WriteLine("\nPolicies with Coverage Type: " + type);

            bool found = false;

            foreach (var p in policyHashSet)
            {
                if (p.CoverageType.Equals(type, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(p);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No matching policies found.");
        }

        public void CheckDuplicatePolicyNumber()
        {
            Console.Write("\nEnter Policy Number to check: ");
            string number = Console.ReadLine();

            Policy dummy = new Policy(number, "dummy", "dummy", DateTime.Now);

            if (policyHashSet.Contains(dummy))
                Console.WriteLine("Policy Number already exists.");
            else
                Console.WriteLine("Policy Number is unique.");
        }
    }

    class InsurancePolicyApp
    {
        static void Main()
        {
            InsurancePolicyManagementSystem system = new InsurancePolicyManagementSystem();

            while (true)
            {
                Console.WriteLine("\nInsurance Policy Management System");
                Console.WriteLine("1. Add Policy");
                Console.WriteLine("2. Show All Unique Policies (HashSet)");
                Console.WriteLine("3. Show Policies in Insertion Order (LinkedHashSet simulation)");
                Console.WriteLine("4. Show Policies Sorted by Expiry Date (SortedSet)");
                Console.WriteLine("5. Show Policies Expiring Soon (Next 30 days)");
                Console.WriteLine("6. Search Policies by Coverage Type");
                Console.WriteLine("7. Check Duplicate Policy Number");
                Console.WriteLine("8. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        system.AddPolicy();
                        break;
                    case 2:
                        system.ShowAllUniquePolicies();
                        break;
                    case 3:
                        system.ShowPoliciesInsertionOrder();
                        break;
                    case 4:
                        system.ShowPoliciesSortedByExpiry();
                        break;
                    case 5:
                        system.ShowExpiringSoonPolicies();
                        break;
                    case 6:
                        system.ShowPoliciesByCoverageType();
                        break;
                    case 7:
                        system.CheckDuplicatePolicyNumber();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

}
