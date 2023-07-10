using Models.Models.Entities.JoiningTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities
{
    public class Category
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        //Navigations
        public IEnumerable<CategoryMaterial> CategoryMaterials { get; } = new List<CategoryMaterial>();
    }
}
