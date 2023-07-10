using Models.Models.Entities.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities
{
    public class Phone
    {
        public int Id { get; private set; }

        public string PhoneNumber { get; private set; }

        //Navigations
        public int? UserId { get; private set; }

        public User? User { get; private set; }

        public int? ContactPersonId { get; private set; }

        public ContactPerson? ContactPerson { get; private set; }
    }
}
