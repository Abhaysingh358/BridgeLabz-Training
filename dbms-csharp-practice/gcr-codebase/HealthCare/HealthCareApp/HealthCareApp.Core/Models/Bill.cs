namespace HealthCareApp.Core.Models
{
    // Represents Bills table
    public class Bill
    {
        public int BillId { get; set; }

        public int VisitId { get; set; }

        public decimal TotalAmount { get; set; }

        public string PaymentStatus { get; set; }

        public DateTime? PaymentDate { get; set; }
    }
}
