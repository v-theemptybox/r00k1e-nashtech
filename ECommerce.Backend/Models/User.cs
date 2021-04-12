using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ECommerce.Backend.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {
        }

        public User(string userName) : base(userName)
        {
        }

        [PersonalData]
        public string FullName { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
