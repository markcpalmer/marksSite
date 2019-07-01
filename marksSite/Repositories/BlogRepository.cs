using marksSite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace marksSite.Repositories
{
    public class BlogRepository : IRepository<Blog>
    {


        private SiteContext db;

        public BlogRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Blog> GetAll()
        {
            return db.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
            return db.Blogs.Single(c => c.Id == id);
        }

        public void Create(Blog obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Blog obj)
        {
            throw new NotImplementedException();
        }
    }
}

