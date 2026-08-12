using ContactApp.Business;
using ContactApp.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ContactApp.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]  // this make the routes api/contacts
    public class ContactController : ControllerBase
    {
        private readonly IContactService _service;
        public ContactController(IContactService service)
        {
            _service = service;
        }

        // Get All Contacts 
        [HttpGet]
        public IActionResult GetAllContacts()
        {
            IEnumerable<ContactDTO> contacts = _service.GetAllContacts();
            return Ok(contacts);
        }

        [HttpGet("{id}")]
            public IActionResult GetContactById(int id)
        {
            ContactDTO? contact = _service.GetContactById(id);
            if (contact == null)
            {
                return NotFound($"Contact with ID {id} was not found.");
            }
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult CreateContact(ContactCreatDTO dto)
        {
            // The service saves data and updates the ID from 0 to the database ID
            ContactDTO createdContact = _service.CreateContact(dto);
            return CreatedAtAction(nameof(GetContactById) , new { id = createdContact.Id }, createdContact);

        }
    }
}