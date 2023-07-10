using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities
{
    public class Country
    {
        // ISO Alpha-3 codes
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string PhoneCode { get; private set; }
        
        public IEnumerable<Address> Addresses { get; } = new List<Address>();
    }
}
