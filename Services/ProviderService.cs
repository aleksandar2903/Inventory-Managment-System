using Inventory_Managment_System.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public class ProviderService : IProviderService
    {
        private IMS_DataContext _context;
        public ProviderService(IMS_DataContext _context)
        {
            this._context = _context;
        }
        public void AddProvider(Models.Provider provider)
        {
            _context.Providers.Add(provider);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot insert this record. \n" + ex.Message);
            }
        }

        public void DeleteProvider(int? id)
        {
            _context.Providers.Remove(_context.Providers.Find(id));
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot delete this record. \n" + ex.Message);
            }
        }

        public List<Models.Provider> GetProviders()
        {
            return _context.Providers.AsNoTracking().ToList();
        }

        public Models.Provider GetProvider(int id)
        {
            return _context.Providers.Find(id);
        }

        public void UpdateProvider(Models.Provider provider)
        {
            _context.Providers.Attach(provider).State = EntityState.Modified;
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
