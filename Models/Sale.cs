using System;
using System.Collections.Generic;

#nullable disable

namespace Inventory_Managment_System.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SoldProducts = new HashSet<SoldProduct>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
        public DateTime? FinalizedAt { get; set; }

        public virtual Client Client { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<SoldProduct> SoldProducts { get; set; }
    }
}
