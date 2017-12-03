namespace ToDoodle.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class Context : DbContext
    {
        public Context(): base("ToDoodleCodeFirst")
        {
            Database.SetInitializer<Context>(new Initializer());
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}