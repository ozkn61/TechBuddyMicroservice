using Contact.Api.Infrastructure;
using Contact.Api.Model;

namespace Contact.Api.Service
{
    public class ContactService : IContactService
    {
        public ContactDto GetContactById(int id)
        {
            return new ContactDto
            {
                Id = id,
                FirstName = "Keanu",
                LastName = "Reeves"
            };
        }
    }
}
