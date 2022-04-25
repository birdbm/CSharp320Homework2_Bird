using Homework2.Extensions;

namespace Homework2.Models
{
    public class Contacts
    {
        private List<Contact> _contacts = new List<Contact>();
        public Contacts()
        {
            AddContact(new Contact { Id = 1, Name = "Dave", City = "Seattle", State = "WA", Phone = "123-456-7890" });
            AddContact(new Contact { Id = 2, Name = "Mike", City = "Spokane", State = "WA", Phone = "456-123-7890" });
            AddContact(new Contact { Id = 3, Name = "Lisa", City = "San Jose", State = "CA", Phone = "321-456-7890" });
            AddContact(new Contact { Id = 4, Name = "Cathy", City = "Dallas", State = "TX", Phone = "789-123-7890" });
        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public IEnumerable<Contact> GetContacts(string? sortKey = null,string? sortDir = null)
        {
            return _contacts.SortByKey<Contact>(sortKey, sortDir);
        }
    }
}
