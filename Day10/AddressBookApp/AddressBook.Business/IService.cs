using AddressBook.Models;
namespace AddressBook.Business
{
    public interface IService
    {
         List<Contact> GetAll();
        Contact GetById(int id);

        void Add(Contact contact);

        void Update(Contact contac);

        void Delete(int id);
    }
}