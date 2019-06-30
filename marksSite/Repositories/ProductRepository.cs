using marksSite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace marksSite.Repositories
{
    public class ProductRepository : IRepository<Product>
    {


        private SiteContext db;

        public ProductRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.Single(c => c.Id == id);
        }

        public void Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}

