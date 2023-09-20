using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Entities
{
    public partial class Items
    {
        public Items()
        {
            ItemPrinters = new HashSet<ItemPrinters>();
            OrderItems = new HashSet<OrderItems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<ItemPrinters> ItemPrinters { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
