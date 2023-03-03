using Contact.Api.Infrastructure;
using Contact.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public ContactDto Get(int id)
        {
            return _contactService.GetContactById(id);
        }
    }
}
