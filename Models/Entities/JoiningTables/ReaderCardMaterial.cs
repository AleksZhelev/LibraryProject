using Models.Models.Entities.UserAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities.JoiningTables
{
    public class ReaderCardMaterial
    {
        public int Id { get; private set; }

        public DateTime LeaseDate { get; private set; } = DateTime.Now;

        // IS it better to calculate the DueDate,
        // as I intend to have the system look through all leased materials and send an email or text for due materials?
        public DateTime DueDate { get; private set; }

        public DateTime ReturnedDate { get; private set; }

        [NotMapped]
        private readonly int daysForALease = 20;

        public int timesLeaseCanBeExtended { get; private set; } = 2;

        public ReaderCardMaterial() 
        { 
            if(ReaderCard.readerCardMaterials.Any(x => x.MaterialId == MaterialId) || ReaderCard.readerCardMaterials.Any(x => x.DueDate < DateTime.Now))
            {
                throw new InvalidOperationException("Reader has already leased the same material or has materials past their due date.");
            }

            DueDate = DateTime.Now.AddDays(daysForALease);
        }

        /// <summary>
        /// Method used to extend the lease of materials.
        /// </summary>
        /// <returns>A new <see cref="DateTime"></see> for DueDate.</returns>
        public DateTime ExtendLease()
        {
            if(timesLeaseCanBeExtended > 0 && ReaderCard.CheckRemainingValidity() > TimeSpan.FromDays(daysForALease * (timesLeaseCanBeExtended + 1)))
            {
                timesLeaseCanBeExtended--;

                DueDate.AddDays(daysForALease);
            }

                return DueDate;
        }

        // Navigations
        public int ReaderCardId { get; private set; }

        public ReaderCard ReaderCard { get; private set; }

        public int MaterialId { get; private set; }

        public Material Material { get; private set; }
    }
}
