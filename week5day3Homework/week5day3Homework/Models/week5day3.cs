namespace week5day3Homework.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class week5day3 : DbContext
    {
        // Your context has been configured to use a 'week5day3' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'week5day3Homework.Models.week5day3' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'week5day3' 
        // connection string in the application configuration file.
        public week5day3()
            : base("name=week5day3")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual Dbset<Post> Posts { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}