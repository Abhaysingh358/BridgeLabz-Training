using ContactApp.Repository.Data;
using ContactApp.Models.Entity;
using Microsoft.EntityFrameworkCore;
namespace ContactApp.Repository
{
    public class ContactRepository : IContactRepositry
    {
        private readonly ContactDbContext _context ;

        public ContactRepository(ContactDbContext context)
        {
            _context  = context;
        }

        public IEnumerable<Contact> GetAll()
        {
            return _context.Contacts.ToList();
        }

        public Contact ?  GetById(int id)
        {
            return _context.Contacts.Find(id);
        }

        public void Add(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

         public void Update(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var contact = GetById(id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }
        }
    }
}