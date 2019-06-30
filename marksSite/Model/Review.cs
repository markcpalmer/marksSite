using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace marksSite.Model
{
    public class Review
    {

        public int ReviewId { get; set; }
        // [Display(Content="Enter Your review here")]
        public string Content { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
