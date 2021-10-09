using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public interface ISaleService
    {
        List<Models.Sale> GetSales();
        Models.Sale GetSale(int id);
        void AddSale(Models.Sale sale);
    }
}
