using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArtXchange.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Class { get; set; }

        //Not adding the role to the DB
        [NotMapped]
        public string Role { get; set; }
    }
}
