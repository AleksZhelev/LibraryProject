using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities.AuthorAggregate
{
    public class Alias
    {
        public int Id { get; private set; }

        public string AliasName { get; private set; }

        //Navigations
        public int AuthorId { get; private set; }

        public Author Author { get; private set; }
    }
}
