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
    public class PurchaseService : IPurchaseService
    {
        private IMS_DataContext _context;
        public PurchaseService(IMS_DataContext _context)
        {
            this._context = _context;
        }
        public void AddPurchase(Receipt purchase)
        {
            _context.Receipts.Attach(purchase).State = EntityState.Added;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot insert this record. \n" + ex.Message);
            }
        }

        public Receipt GetPurchase(int id)
        {
            return _context.Receipts.Include(c => c.Provider).Include(u => u.User).Include(s => s.ReceivedProducts).ThenInclude(p => p.Product).FirstOrDefault(Id => Id.Id == id);
        }

        public List<Receipt> GetPurchases()
        {
            return _context.Receipts.Include(s => s.ReceivedProducts).AsNoTracking().ToList();
        }
    }
}
