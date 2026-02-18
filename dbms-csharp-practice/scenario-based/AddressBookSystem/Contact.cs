namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // keep your existing methods (do not remove)
        public void SetFirstName(string firstName) => FirstName = firstName;
        public string GetFirstName() => FirstName;

        public void SetLastName(string lastName) => LastName = lastName;
        public string GetLastName() => LastName;

        public void SetAddress(string address) => Address = address;
        public string GetAddress() => Address;

        public void SetCity(string city) => City = city;
        public string GetCity() => City;

        public void SetState(string state) => State = state;
        public string GetState() => State;

        public void SetZip(string zip) => Zip = zip;
        public string GetZip() => Zip;

        public void SetPhoneNumber(string phone) => PhoneNumber = phone;
        public string GetPhoneNumber() => PhoneNumber;

        public void SetEmail(string email) => Email = email;
        public string GetEmail() => Email;

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {Address}, {City}, {State}, {Zip}, {PhoneNumber}, {Email}";
        }
    }
}
