using System;
using System.Collections.Generic;

#nullable disable

namespace UrbanCompany.API.Models
{
    public partial class SubService
    {
        public SubService()
        {
            Carts = new HashSet<Cart>();
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int SubServiceId { get; set; }
        public string SubServiceName { get; set; }
        public int? ServiceId { get; set; }
        public int Cost { get; set; }

        public virtual ServicesCategory Service { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
