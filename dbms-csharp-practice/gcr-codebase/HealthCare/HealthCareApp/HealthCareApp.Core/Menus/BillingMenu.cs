using HealthCareApp.Core.Repositories;

namespace HealthCareApp.Core.Menus
{
    // Handles billing console operations
    public class BillingMenu
    {
        private readonly BillingRepository _billingRepository;

        public BillingMenu()
        {
            _billingRepository = new BillingRepository();
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Billing Management");
                Console.WriteLine("1. Generate Bill");
                Console.WriteLine("2. Record Payment");
                Console.WriteLine("3. View Bills");
                Console.WriteLine("4. Back");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Visit Id: ");
                    int visitId = int.Parse(Console.ReadLine());

                    _billingRepository.GenerateBill(visitId);

                    Console.WriteLine("Bill generated successfully.");
                }
                else if (choice == "2")
                {
                    Console.Write("Bill Id: ");
                    int billId = int.Parse(Console.ReadLine());

                    Console.Write("Amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());

                    Console.Write("Payment Mode: ");
                    string mode = Console.ReadLine();

                    _billingRepository.RecordPayment(billId, amount, mode);

                    Console.WriteLine("Payment recorded successfully.");
                }
                else if (choice == "3")
                {
                    var bills = _billingRepository.GetAllBills();

                    foreach (var b in bills)
                    {
                        Console.WriteLine(b.BillId + " , Visit: " +
                                          b.VisitId + " , Amount: " +
                                          b.TotalAmount + " , Status: " +
                                          b.PaymentStatus);
                    }
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}
