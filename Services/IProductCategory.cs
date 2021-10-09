using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public interface IProductCategory
    {
        List<Models.ProductCategory> GetCategories();
        void AddProductCategory(Models.ProductCategory productCategory);
        void UpdateProductCategory(Models.ProductCategory productCategory);
        void DeleteProductCategory(int? id);

    }
}
