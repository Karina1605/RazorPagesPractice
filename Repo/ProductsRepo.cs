using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPages.DataBaseModels;

namespace TestPages.Repo
{
    public class ProductsRepo : ICrud<Product>
    {
        DataBaseContext _context;
        public ProductsRepo(DataBaseContext context)
        {
            _context = context;
        }
        public async Task<Product> Create(Product item)
        {
            await _context.Products.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Product> Delete(Product item)
        {
            _context.Products.Remove(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.Select(e => e).ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.Where(e => e.Id == id).Select(e => e).FirstOrDefaultAsync();
        }

        public async Task<Product> Update(Product item)
        {
            _context.Products.Update(item);
            await _context.SaveChangesAsync();
            return item;
        }
    }
}
