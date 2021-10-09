using Inventory_Managment_System.Data;
using Inventory_Managment_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public class SaleService : ISaleService
    {
        private IMS_DataContext _context;
        public SaleService(IMS_DataContext _context)
        {
            this._context = _context;
        }
        public void AddSale(Sale sale)
        {
            _context.Sales.Add(sale);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot insert this record. \n" + ex.Message);
            }
        }

        public Sale GetSale(int id)
        {
            return _context.Sales.Include(c => c.Client).Include(u => u.User).Include(u => u.User).Include(s => s.SoldProducts).ThenInclude(p=> p.Product).FirstOrDefault(Id => Id.Id == id);
        }

        public List<Sale> GetSales()
        {
            return _context.Sales.Include(s => s.SoldProducts).AsNoTracking().ToList();
        }
    }
}
