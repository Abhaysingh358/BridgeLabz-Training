using System.Runtime.CompilerServices;
using ContactApp.Models.Entity;

namespace ContactApp.Repository
{
    public interface IContactRepositry
    {
        IEnumerable<Contact> GetAll();

        Contact ? GetById(int id);

        void Add(Contact contact);
        void Update (Contact contact);
        void Delete(int id);
    }
}