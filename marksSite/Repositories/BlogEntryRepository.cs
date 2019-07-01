using marksSite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Repositories
{
    public class BlogEntryRepository : IRepository<BlogEntry>
    {
        private SiteContext db;

        public BlogEntryRepository(SiteContext db)
        {
            this.db = db;
        }
        public IEnumerable<BlogEntry> GetAll()
        {
            return db.BlogEntrys.ToList();
        }

        public BlogEntry GetById(int BlogEntryId)
        {
            return db.BlogEntrys.Single(c => c.BlogEntryId == BlogEntryId);
        }

        public void Create(BlogEntry review)
        {
            db.BlogEntrys.Add(review);
            db.SaveChanges();
        }

        public void Delete(BlogEntry review)
        {
            db.BlogEntrys.Remove(review);
            db.SaveChanges();
        }

        public void Edit(BlogEntry review)
        {
            db.BlogEntrys.Update(review);
            db.SaveChanges();
        }
    }
}
