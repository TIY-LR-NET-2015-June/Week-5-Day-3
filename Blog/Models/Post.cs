using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Post
    {
        public int? ID { get; set; }

        [Required]
        [StringLength(75)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }
        public DateTime PublishedOn { get; private set; }

        public Post()
        {
            PublishedOn = DateTime.Now;
        }
    }
}