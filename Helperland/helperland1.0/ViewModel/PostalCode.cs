using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland1._0.ViewModel
{
   

   
    
        public class PostalCode
        {
            [Required]
        [StringLength(6, ErrorMessage = "Please Enter Valid Postal Code")]
        public string postalcode { get; set; }
        }
    
}
