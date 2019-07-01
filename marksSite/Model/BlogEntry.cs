using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Model
{
    public class BlogEntry
    {

        public int BlogEntryId { get; set; }
        // [Display(Content="Enter Your review here")]
        public string EntryTitle { get; set; }
        public string Content { get; set; }
        public DateTime PostTime { get; set; }

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }

        public BlogEntry() {
            PostTime = DateTime.Now;
        }
    }
}
