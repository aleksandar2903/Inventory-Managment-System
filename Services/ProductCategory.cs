using Inventory_Managment_System.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Services
{
    public class ProductCategory : IProductCategory
    {
        private  IMS_DataContext _context;
        public ProductCategory(IMS_DataContext _context)
        {
            this._context = _context;
        }

        public void AddProductCategory(Models.ProductCategory productCategory)
        {
            _context.ProductCategories.Attach(productCategory).State = EntityState.Added;
            try
            {
                _context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot insert this record. \n" + ex.Message);
            }
        }

        public void DeleteProductCategory(int? id)
        {
            _context.ProductCategories.Remove(_context.ProductCategories.Find(id)).State = EntityState.Deleted;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot delete this record. \n"+ex.Message);
            }
        }

        public List<Models.ProductCategory> GetCategories()
        {
            return _context.ProductCategories.AsNoTracking().ToList();
        }

        public void UpdateProductCategory(Models.ProductCategory productCategory)
        {
            _context.ProductCategories.Attach(productCategory).State = EntityState.Modified;
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
