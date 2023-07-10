using Microsoft.Identity.Client;
using Models.Models.Entities.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities
{
    public class Address
    {
        public int Id { get; private set; }

        public string StreetName { get; private set; }

        public string StreetNumber { get; private set; }

        public string City { get; private set; }

        public string PostCode { get; private set; }

        //Navigations
        public int CountryId { get; private set; }

        public Country Country { get; private set; }

        public int? PublisherId { get; private set; }

        public Publisher? Publisher { get; private set; }

        public int? UserId { get; private set; }

        public User? User { get; private set; }
    }
}
