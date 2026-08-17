using System.ComponentModel.DataAnnotations;

 namespace AddressBook.Models.DTO{
 public class ContactCreateDTO
    {
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; } = string.Empty;
        
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "PinCode must be exactly 6 digits")]
        public string PinCode { get; set; } = string.Empty;
    }
 }