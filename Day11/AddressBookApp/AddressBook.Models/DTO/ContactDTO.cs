namespace AddressBook.Models
{
    public class ContactDTO
    {
        
         public int id { get; set; } // Add id back if your client sends it, or drop it
        public string Name { get; set; } = "";
        public string City { get; set; } = "";
        public string Country { get; set; } = "";
        public string PinCode { get; set; } = "";
    }
}