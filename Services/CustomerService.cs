using Inventory_Managment_System.Data;
using Inventory_Managment_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_Managment_System.Services
{
    public class CustomerService : ICustomerService
    {
        private IMS_DataContext _context;
        public CustomerService(IMS_DataContext _context)
        {
            this._context = _context;
        }

        public void AddCustomer(Models.Client customer)
        {
            _context.Clients.Add(customer);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot insert this record. \n" + ex.Message);
            }
        }

        public void DeleteCustomer(int? id)
        {
            _context.Clients.Remove(_context.Clients.Find(id));
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot delete this record. \n" + ex.Message);
            }
        }

        public List<Models.Client> GetCustomers()
        {
            return _context.Clients.Include(p => p.Sales).AsNoTracking().ToList();
        }

        public Models.Client GetCustomer(int id)
        {
            return _context.Clients.Include(p => p.Sales).ThenInclude(s=>s.SoldProducts).ThenInclude(i => i.Product).AsNoTracking().FirstOrDefault(Id=>Id.Id == id);
        }

        public void UpdateCustomer(Models.Client customer)
        {
            _context.Clients.Attach(customer).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot update this record. \n" + ex.Message);
            }
        }
    }
}
