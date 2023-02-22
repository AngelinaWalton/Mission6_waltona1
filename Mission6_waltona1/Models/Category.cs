﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_waltona1.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
