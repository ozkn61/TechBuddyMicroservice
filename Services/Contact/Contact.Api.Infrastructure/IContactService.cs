using Contact.Api.Model;

namespace Contact.Api.Infrastructure
{
    public interface IContactService
    {
        public ContactDto GetContactById(int id);
    }
}
