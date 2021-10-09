using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public interface ICustomerService
    {
        List<Models.Client> GetCustomers();
        Models.Client GetCustomer(int id);
        void AddCustomer(Models.Client customer);
        void UpdateCustomer(Models.Client customer);
        void DeleteCustomer(int? id);
    }
}
