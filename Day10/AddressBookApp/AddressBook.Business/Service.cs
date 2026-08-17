using AddressBook.Repository;
using AddressBook.Models;

namespace AddressBook.Business
{
    public class Service : IService
    {
        private readonly IRepository _repo;

        public Service(IRepository repo)
        {
            _repo = repo;
        }

        public List<Contact> GetAll()
        {
            List<Contact> contacts = _repo.GetAll();
            return contacts;
        }

        public Contact GetById(int id) => _repo.GetById(id);

        public void Add(Contact c) => _repo.Add(c);

        public void Update(Contact c) => _repo.Update(c);

        public void Delete(int id) => _repo.Delete(id);
       
    }
}