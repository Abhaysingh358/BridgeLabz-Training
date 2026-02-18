using HealthCareApp.Core.Models;

namespace HealthCareApp.Core.Interfaces
{
    // Defines billing operations
    public interface IBillingRepository
    {
        void GenerateBill(int visitId);

        void RecordPayment(int billId, decimal amount, string paymentMode);

        List<Bill> GetAllBills();
    }
}
