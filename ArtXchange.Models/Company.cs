﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArtXchange.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public bool isAuthorized { get; set; }
    }
}
