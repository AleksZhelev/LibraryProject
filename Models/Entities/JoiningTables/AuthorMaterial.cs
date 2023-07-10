using Models.Models.Entities.AuthorAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities.JoiningTables
{
    public class AuthorMaterial
    {
        public int AuthorId { get; private set; }

        public Author Author { get; private set; }

        public int MaterialId { get; private set; }

        public Material Material { get; private set; }
    }
}
