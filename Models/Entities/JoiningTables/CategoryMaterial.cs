using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities.JoiningTables
{
    public class CategoryMaterial
    {
        public int CategoryId { get; private set; }

        public Category Category { get; private set; }

        public int MaterialId { get; private set; }

        public Material Material { get; private set; }
    }
}
