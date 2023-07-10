using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Enums
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum ReasonForDeactivation
    {
        Expired,
        Lost,
        Violation
    }

    public enum MaterialType
    {
        Book,
        CDAudioBook,
        CDMovie,
        CDMusic,
        Map,
        Graphic
    }

    public enum MaterialReadingStatus
    {
        ForHome,
        ForLibrary
    }

    public enum ContactPersonType
    {
        FLP,
        Contact
    }
}
