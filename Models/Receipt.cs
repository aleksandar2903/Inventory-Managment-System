using System;
using System.Collections.Generic;

#nullable disable

namespace Inventory_Managment_System.Models
{
    public partial class Receipt
    {
        public Receipt()
        {
            ReceivedProducts = new HashSet<ReceivedProduct>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int ProviderId { get; set; }
        public int UserId { get; set; }
        public DateTime? FinalizedAt { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ReceivedProduct> ReceivedProducts { get; set; }
    }
}
