using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BulkyBook.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        //NotMapped annotation means that this property will not be pushed to database
        [NotMapped]
        public string Role { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
