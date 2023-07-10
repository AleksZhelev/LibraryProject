using Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities
{
    public class ContactPerson
    {
        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public ContactPersonType Type { get; private set; }

        //Navigations
        public int PublisherId { get; private set; }

        public Publisher Publisher { get; private set; }

        public IEnumerable<Phone> Phones { get; } = new List<Phone>();

        public IEnumerable<Email> Emails { get; } = new List<Email>();
    }
}
