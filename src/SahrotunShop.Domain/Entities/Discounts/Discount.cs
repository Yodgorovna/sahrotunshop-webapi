﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahrotunShop.Domain.Entities.Discounts
{
    public class Discount : Auditable
    {
        [MaxLength(50)]
        public string Name { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;       
    }
}
