namespace Blog.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Posts : DbContext
    {
        public Posts()
            : base("Posts")
        {

            Database.SetInitializer<Posts>(new CreateDatabaseIfNotExists<Posts>());

        }
        public virtual DbSet<Post> PostDB { get; set; }
    }
}
