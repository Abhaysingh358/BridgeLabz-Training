using AddressBook.Models;

namespace AddressBook.Repository
{
    public interface IRepository
    {
        List<Contact> GetAll();
        Contact GetById(int id);

        void Add(Contact contact);

        void Update(Contact contac);

        void Delete(int id);



    }
}