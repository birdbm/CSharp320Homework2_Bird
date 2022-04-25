namespace Homework2.Models
{
    public class Contacts
    {
        private List<Contact> _contacts = new List<Contact>();
        const string descKey = "_desc";
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

        public IEnumerable<Contact> GetContacts(string? sortOrder = null)
        {
            if (sortOrder != null)
            {
                switch (sortOrder.ToLowerInvariant())
                {
                    case "id":
                        return _contacts.OrderBy(x => x.Id);
                    case "id" + descKey:
                        return _contacts.OrderByDescending(x => x.Id);
                    case "name":
                        return _contacts.OrderBy(x => x.Name);
                    case "name" + descKey:
                        return _contacts.OrderByDescending(x => x.Name);
                    case "city":
                        return _contacts.OrderBy(x => x.City);
                    case "city" + descKey:
                        return _contacts.OrderByDescending(x => x.City);
                    case "state":
                        return _contacts.OrderBy(x => x.State);
                    case "state" + descKey:
                        return _contacts.OrderByDescending(x => x.State);
                    case "phone":
                        return _contacts.OrderBy(x => x.Phone);
                    case "phone" + descKey:
                        return _contacts.OrderByDescending(x => x.Phone);
                }
            }
                return _contacts;
        }
    }
}
