﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCpartStore.Models
{
    public class ShippingDetails
    {
        public string Name { get; set; }

        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        public string City { get; set; }
        public string PostCode{ get; set; }

        public string Country { get; set; }
    }
}