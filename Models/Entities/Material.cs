using Models.Models.Entities.AuthorAggregate;
using Models.Models.Entities.JoiningTables;
using Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities
{
    public class Material
    {
        public int Id { get; private set; }

        public MaterialType Type { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        //ISBN for Books, ISAN for Movies and so on
        public string ISIdentifier { get; private set; }

        public DateTime IssueDate { get; private set; }

        public MaterialReadingStatus Status { get; private set; }

        public int Quantity { get; private set; }

        // Navigations
        public int PublisherId { get; private set; }

        public Publisher Publisher { get; private set; }

        //IEnumerable<AuthorAggregate> What does it mean?
        public IEnumerable<AuthorMaterial> AuthorMaterials { get; } = new List<AuthorMaterial>();

        public IEnumerable<CategoryMaterial> CategoryMaterials { get; } = new List<CategoryMaterial>();

        /// <summary>
        /// Checks if there are any copies of the material left and reduces it by one.
        /// </summary>
        /// <returns>True if there is at least one copy and reduces the Quantity by one, else returns false.</returns>
        public bool CheckIfHasQuantity()
        {
            if(Quantity > 0)
            {
                Quantity--;
                return true;
            }

            return false;
        }
    }
}
