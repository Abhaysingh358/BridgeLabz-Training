using AddressBook.Models;

namespace AddressBook.Repository
{
    public class Repository : IRepository
    {
        private readonly AddressBookContext _context;

        public Repository(AddressBookContext context)
        {
            _context = context;
        }

        public List<Contact> GetAll() => _context.Contacts.ToList();

        public Contact GetById(int id) => _context.Contacts.Find(id);

        public void Add(Contact contact){
             _context.Contacts.Add(contact);
             _context.SaveChanges();
            
            }

            public void Update(Contact c)
        {
            _context.Contacts.Update(c);
            _context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            var c = GetById(id);
            if (c != null)
            {
                _context.Contacts.Remove(c);
                _context.SaveChanges();
            }
            
        }

    }
}