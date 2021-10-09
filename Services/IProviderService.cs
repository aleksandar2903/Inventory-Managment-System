using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public interface IProviderService
    {
        List<Models.Provider> GetProviders();
        Models.Provider GetProvider(int id);
        void AddProvider(Models.Provider provider);
        void UpdateProvider(Models.Provider provider);
        void DeleteProvider(int? id);
    }
}
