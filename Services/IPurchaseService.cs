using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public interface IPurchaseService
    {
        List<Models.Receipt> GetPurchases();
        Models.Receipt GetPurchase(int id);
        void AddPurchase(Models.Receipt purchase);
    }
}
