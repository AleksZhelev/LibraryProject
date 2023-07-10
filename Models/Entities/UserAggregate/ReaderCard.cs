using Microsoft.IdentityModel.Tokens;
using Models.Models.Entities.JoiningTables;
using Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities.UserAggregate
{
    public class ReaderCard
    {
        public int Id { get; private set; }

        public DateTime IssueDate { get; private set; } = DateTime.Now;

        public ReasonForDeactivation? ReasonForDeactivation { get; private set; }

        public DateTime? DeactivationDate { get; private set; }

        public ReaderCard() 
        {
            if(User.ViolationPenaltyExpirationDate != null && User.ViolationPenaltyExpirationDate >= DateTime.Now)
            {
                throw new InvalidOperationException("The user has yet to serve their time.");
            }
        }

        // Navigations
        public IEnumerable<ReaderCardMaterial> readerCardMaterials { get; } = new List<ReaderCardMaterial>();

        public int UserId { get; private set; }

        public User User { get; private set; }

        // Should the reason in the following method be a string or an enum?

        /// <summary>
        /// Sets the reason for deactivation and the deactivation date.
        /// </summary>
        /// <param name="reason"></param>
        public void Deactivate(string reason)
        {
            if(reason != null)
            {
                if((ReasonForDeactivation)Enum.Parse(typeof(ReasonForDeactivation), reason) == Enums.ReasonForDeactivation.Violation)
                {
                    User.SetViolationExpiryDateTime();
                }

                ReasonForDeactivation = (ReasonForDeactivation)Enum.Parse(typeof(ReasonForDeactivation), reason);

                DeactivationDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Checks the remaining validity time.
        /// </summary>
        /// <returns> A <see cref="TimeSpan"></see>of how much time is left on the card.</returns>
        public TimeSpan CheckRemainingValidity()
        {
            return DateTime.Now.Subtract(IssueDate);
        }
    }
}
