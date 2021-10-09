using System;
using System.Collections.Generic;

#nullable disable

namespace Inventory_Managment_System.Models
{
    public partial class Provider
    {
        public Provider()
        {
            Receipts = new HashSet<Receipt>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Paymentinfo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
