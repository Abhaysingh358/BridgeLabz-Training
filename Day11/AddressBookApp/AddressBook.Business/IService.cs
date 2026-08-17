using AddressBook.Models.Model;
namespace AddressBook.Business
{
    public interface IService
    {
         List<ContactModel> GetAll();
        ContactModel GetById(int id);

        void Add(ContactModel contact);

        void Update(ContactModel contac);

        void Delete(int id);
    }
}