using marksSite.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite
{
    public class SiteContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogEntry> BlogEntrys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=marksSite;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Analog",
                },

                new Category()
                {
                    Id = 2,
                    Name = "Digital",
                }
            );

            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    Id = 1,
                    Name = "Rollex Date Just 41",
                    Description = "Rolex Datejust 41 Sundust Dial Steel and 18K Everose Gold Mens Watch 126331SNSO",
                    Image = "image.jpg",
                    CategoryId = 1
                },

                new Blog()
                {
                    Id = 2,
                    Name = "Rollex 2",
                    Description = "This is a test description",
                    Image = "watch.jpeg",
                    CategoryId = 1
                },

                new Blog()
                {
                    Id = 3,
                    Name = "Some watches rock",
                    Description = "Watches with lots of diamonds are still cool",
                    Image = "watch.jpg",
                    CategoryId = 2
                },

                new Blog()
                {
                    Id = 4,
                    Name = "Energy Watch",
                    Description = "Solar watches are the new hot thing!",
                    Image = "solarwatch.jpg",
                    CategoryId = 2
                }

            );

            modelBuilder.Entity<BlogEntry>().HasData(
                new BlogEntry()
                {
                    BlogEntryId = 1,
                    Content = "These watches make mankind stop time.",
                    BlogId = 1,
                },
                new BlogEntry()
                {
                    BlogEntryId = 2,
                    Content = "I have never seen a watch so cool.  It makes me shiver just to look at it.",
                    BlogId = 2,
                },
                new BlogEntry()
                {
                    BlogEntryId = 3,
                    Content = "This is a great watch. Just like my grandfathers only better",
                    BlogId = 3,
                },
                new BlogEntry()
                {
                    BlogEntryId = 4,
                    Content = "This watch is so heavy it makes my arm hurt.  Don't buy it.",
                    BlogId = 4,
                }
            );
        }
    }
}
