using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext() : base("BloggingDatabase")
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    // See https://msdn.microsoft.com/en-us/data/dn456835
    public class MyConfiguration : DbConfiguration
    {
        public MyConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy(4, TimeSpan.FromSeconds(30)));
        }
    }
}