using System;
using System.Collections.Generic;

#nullable disable

namespace Inventory_Managment_System.Models
{
    public partial class User
    {
        public User()
        {
            Receipts = new HashSet<Receipt>();
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
