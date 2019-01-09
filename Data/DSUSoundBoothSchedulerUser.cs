using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Data
{
    // Add profile data for application users by adding properties to the DSUSoundBoothSchedulerUser class
    public class DSUSoundBoothSchedulerUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string StudentID { get; set; }
        [PersonalData]
        public bool IsCertified { get; set; }
        [PersonalData]
        public bool IsAdmin { get; set; }
    }
}
