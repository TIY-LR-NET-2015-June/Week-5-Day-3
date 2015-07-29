using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week5.Day3_HW.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(140)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }
        public DateTime PublishedOn { get; set; }
        
    }
}