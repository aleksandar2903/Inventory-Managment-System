using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public interface IProductService
    {
        List<Models.Product> GetProducts();
        Models.Product GetProduct(int id);
        List<Models.ProductCategory> GetProductCategories();
        void AddProduct(Models.Product product);
        void UpdateProduct(Models.Product product);
        void DeleteProduct(int? id);
    }
}
