using System;
using System.Collections.Generic;

#nullable disable

namespace UrbanCompany.API.Models
{
    public partial class Provider
    {
        public Provider()
        {
            Carts = new HashSet<Cart>();
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderPhone { get; set; }
        public string ProviderEmail { get; set; }
        public string ProviderCity { get; set; }
        public string ProviderDistrict { get; set; }
        public int? Service { get; set; }

        public virtual ServicesCategory ServiceNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
