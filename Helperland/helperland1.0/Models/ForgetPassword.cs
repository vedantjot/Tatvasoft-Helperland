﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace helperland1._0.Models
{
    public class ForgetPassword
    {
        [Required]
        public string Email { get; set; }
    }
}
