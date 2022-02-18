using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace helperland1._0.Models
{
    public partial class UserAddress
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        [Required]
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        public string State { get; set; }
        [Required]
        [StringLength(6, ErrorMessage = "Please Enter Valid Postal Code", MinimumLength = 6)]
        public string PostalCode { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Please Enter Valid Phone No")]
        public string Mobile { get; set; }
        public string Email { get; set; }

        public virtual User User { get; set; }
    }
}
