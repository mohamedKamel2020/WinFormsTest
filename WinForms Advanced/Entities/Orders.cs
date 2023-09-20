using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TaxPrice { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
