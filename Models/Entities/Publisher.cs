using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities
{
    public class Publisher
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string VATNumber { get; private set; }

        public string IBAN { get; private set; }

        //Navigations
        public IEnumerable<ContactPerson> Persons { get; } = new List<ContactPerson>();

        public IEnumerable<Address> Address { get; } = new List<Address>();
    }
}
