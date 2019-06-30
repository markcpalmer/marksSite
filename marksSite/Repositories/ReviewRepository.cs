using marksSite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        private SiteContext db;

        public ReviewRepository(SiteContext db)
        {
            this.db = db;
        }
        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public Review GetById(int Reviewid)
        {
            return db.Reviews.Single(c => c.ReviewId == Reviewid);
        }

        public void Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public void Delete(Review review)
        {
            db.Reviews.Remove(review);
            db.SaveChanges();
        }

        public void Edit(Review review)
        {
            db.Reviews.Update(review);
            db.SaveChanges();
        }
    }
}
