using AddressBook.Repository;
using AddressBook.Models.Model;
using AddressBook.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AddressBook.Business
{
    public class Service : IService
    {
        private readonly IRepository _repo;

        public Service(IRepository repo)
        {
            _repo = repo;
        }

        public List<ContactModel> GetAll()
        {
            List<ContactModel> contacts = new List<ContactModel>();

            contacts =  _repo.GetAll().Select(c => new ContactModel
            {
                Id = c.Id,
                Name = c.Name,
                City = c.City,
                Country = c.Country,
                PinCode = c.PinCode
            }).ToList();

            return contacts;
        }

        public ContactModel GetById(int id) {
            var c = _repo.GetById(id);
            if (c == null) return null;

            ContactModel cm = new ContactModel{Id = c.Id , 
            Name =c.Name ,
            City = c.City ,
            PinCode = c.PinCode};
            
            return cm;

        }

        public void Add(ContactModel model) {
            Contact contact = new Contact
            {
                Name = model.Name,
                City = model.City,
                PinCode = model.PinCode
            };

            _repo.Add(contact);

            model.Id = contact.Id; // Sync back the database generated ID
        }

        public void Update(ContactModel model) {
             Contact contact = new Contact
            {
                Id = model.Id,
                Name = model.Name,
                City = model.City,
                PinCode = model.PinCode
            };

            _repo.Update(contact);
        }

        public void Delete(int id) => _repo.Delete(id);
       
    }
}