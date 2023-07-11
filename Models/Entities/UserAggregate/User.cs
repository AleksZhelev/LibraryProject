using Models.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities.UserAggregate
{
    public class User
    {
        public string PID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Gender Gender { get; private set; }

        public string PIDN { get; private set; }

        public DateTime CreatedDate { get; private set; } = DateTime.Now;

        public DateTime? LastUpdatedDate { get; private set; }

        public DateTime? DeletedDate { get; private set; }

        public DateTime? ViolationPenaltyExpirationDate { get; private set; }

        // Navigations
        public IEnumerable<ReaderCard> ReaderCards { get; } = new List<ReaderCard>();

        public IEnumerable<Email> Emails { get; } = new List<Email>();

        public IEnumerable<Phone> Phones { get; } = new List<Phone>();

        public IEnumerable<Address> Addresses { get; } = new List<Address>();

        public User()
        {
            // Gender is encoded in the next to last digit in the PID, odd for Female, even and 0 for Male
            Gender = int.Parse(PID[8].ToString()) % 2 == 0 ? Gender.Male : Gender.Female;
        }

        /// <summary>
        /// Calculates the Date of birth of the User based on their PID.
        /// </summary>
        /// <returns>A <see cref="DateOnly"/> object with the date of birth</returns>
        public DateOnly GetBirthDate()
        {
            if (PID[2] != 4 || PID[2] != 5)
            {
                return new DateOnly(1900 + int.Parse(PID[0].ToString() + PID[1]),
                                           int.Parse(PID[2].ToString() + PID[3]),
                                           int.Parse(PID[4].ToString() + PID[5]));
            }
            else
            {
                // 0150315292 - example of a PID of a person born after 2000
                return new DateOnly(2000 + int.Parse(PID[0].ToString() + PID[1]),
                                           int.Parse(PID[2].ToString() + PID[3]) - 40,
                                           int.Parse(PID[4].ToString() + PID[5]));
            }
        }

        /// <summary>
        /// Sets the violation expiry date to 6 months from now.
        /// </summary>
        public void SetViolationExpiryDateTime()
        {
            ViolationPenaltyExpirationDate = DateTime.Now.AddMonths(6);
        }
    }
}
