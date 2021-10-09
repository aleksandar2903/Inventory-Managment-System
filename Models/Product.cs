using System;
using System.Collections.Generic;

#nullable disable

namespace Inventory_Managment_System.Models
{
    public partial class Product
    {
        public Product()
        {
            ReceivedProducts = new HashSet<ReceivedProduct>();
            SoldProducts = new HashSet<SoldProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductCategoryId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int StockDefective { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ReceivedProduct> ReceivedProducts { get; set; }
        public virtual ICollection<SoldProduct> SoldProducts { get; set; }
    }
}
