using System;
using System.Collections.Generic;

#nullable disable

namespace UrbanCompany.API.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderHistories = new HashSet<OrderHistory>();
        }

        public int OrderId { get; set; }
        public int? Customer { get; set; }
        public string CartReference { get; set; }
        public int TotalCost { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
