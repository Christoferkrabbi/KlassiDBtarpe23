﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiDBtarpe23.Core.Domain
{
    public class Coupon
    {
        [Key]
        public Guid CouponID { get; set; }
        public string StudentName { get; set; }
        public int? Date { get; set; }
       
    }
}
