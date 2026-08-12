using ContactApp.Models.DTO;

namespace ContactApp.Business;

public interface IContactService
{
    IEnumerable<ContactDTO> GetAllContacts();
    ContactDTO ? GetContactById(int id);
    ContactDTO CreateContact(ContactCreatDTO dto );
    // bool UpdateContact(int id, ContactCreateDTO contactUpdateDto);
    // bool DeleteContact(int id);
}
