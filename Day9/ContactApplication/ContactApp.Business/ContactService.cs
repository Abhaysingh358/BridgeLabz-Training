using ContactApp.Models.DTO;
using ContactApp.Models.Entity;
using ContactApp.Repository;
namespace ContactApp.Business
{
    public class ContactService : IContactService
    {
        private readonly ContactRepository _repo;
        
        // get all the repository directly
        public ContactService(ContactRepository repo)
        {
            _repo = repo;
        }

        //Get all
        public IEnumerable<ContactDTO> GetAllContacts()
        {
            var contacts = _repo.GetAll();
            List<ContactDTO> dtos = new List<ContactDTO>();

            foreach(var c in contacts)
            {
                dtos.Add(new ContactDTO
                {
                    Id = c.Id ,FullName = c.FirstName + " " + c.LastName ,Email = c.Email ,PhoneNumber = c.PhoneNumber
                });
            }

            return dtos;
        }
        
         // 2. Get By Id
        public ContactDTO? GetContactById(int id)
        {
            var c = _repo.GetById(id);
            if (c == null) return null;

            return new ContactDTO
            {
                Id = c.Id,
                FullName = c.FirstName + " " + c.LastName,
                Email = c.Email,
                PhoneNumber = c.PhoneNumber
            };
        }

        public ContactDTO CreateContact(ContactCreatDTO dto)
        {
            var entity = new Contact
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber
            };

            _repo.Add(entity);

            return new ContactDTO
            {
                Id = entity.Id,
                FullName = entity.FirstName + " " + entity.LastName,
                 Email = entity.Email,
                PhoneNumber = entity.PhoneNumber
            };
        }
    }
}