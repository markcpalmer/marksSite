using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Blog> Blogs { get; set; }

    }
}
