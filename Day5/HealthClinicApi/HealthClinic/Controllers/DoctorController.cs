using Microsoft.AspNetCore.Mvc;
using HealthClinic.Models;
using HealthClinic.Services;

namespace HealthClinic.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _repository;

        public DoctorController(IDoctorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Doctor> GetAll()
        {
            return _repository.GetAll();
        }
    }
}