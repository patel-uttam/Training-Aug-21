﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UrbanCompany.API.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int Customer { get; set; }
        public int? Provider { get; set; }
        public int? ServiceCategory { get; set; }
        public int? Service { get; set; }
        public int Cost { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
        public virtual Provider ProviderNavigation { get; set; }
        public virtual ServicesCategory ServiceCategoryNavigation { get; set; }
        public virtual SubService ServiceNavigation { get; set; }
    }
}