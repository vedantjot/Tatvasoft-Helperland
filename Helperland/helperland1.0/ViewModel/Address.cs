﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace helperland1._0.ViewModel
{
   

        public class Address
        {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Mobile { get; set; }

      

       

        public bool isDefault { get; set; }
    }
    
}
