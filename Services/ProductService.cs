using Inventory_Managment_System.Data;
using Inventory_Managment_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_Managment_System.Services
{
    public class ProductService : IProductService
    {
        private IMS_DataContext _context;
        public ProductService(IMS_DataContext _context)
        {
            this._context = _context;
        }

        public void AddProduct(Models.Product product)
        {
            _context.Products.Attach(product).State = EntityState.Added;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot insert this record. \n" + ex.Message);
            }
        }

        public void DeleteProduct(int? id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product).State = EntityState.Deleted;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("Cannot delete this record. \n" + ex.Message);
            }
        }

        public List<Models.ProductCategory> GetProductCategories()
        {
            return _context.ProductCategories.AsNoTracking().ToList();
        }

        public List<Models.Product> GetProducts()
        {
            return _context.Products.Include(p => p.ProductCategory).AsNoTracking().ToList();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.Include(c=>c.ProductCategory).Include(r=> r.ReceivedProducts).ThenInclude(e=>e.Receipt).ThenInclude(q=>q.Provider).Include(s=>s.SoldProducts).ThenInclude(l=>l.Sale).ThenInclude(a => a.Client).FirstOrDefault(Id=>Id.Id == id);
        }

        public void UpdateProduct(Models.Product product)
        {
            _context.Products.Attach(product).State = EntityState.Modified;
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
