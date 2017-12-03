using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace ToDoodle.Models
{
    public class Initializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            var defaultUser  = 
                new User { LoginName = "mattlavinder@gmail.com", UserName = "Matt Lavinder", DateCreated = DateTime.Now };

            var users = new List<User> {defaultUser};
            users.ForEach(u => context.Users.Add(u));

            var defaultList =
                new List { Title = "Groceries", User = defaultUser, DateCreated = DateTime.Now };

            var lists = new List<List> { defaultList };
            lists.ForEach(l => context.Lists.Add(l));

            var items = new List<Item> {
                new Item { Title="Milk", User = defaultUser, List = defaultList, DateCreated=DateTime.Now},
                new Item { Title="Bread", User = defaultUser, List = defaultList, DateCreated=DateTime.Now},
                new Item { Title="Eggs", User = defaultUser, List = defaultList, DateCreated=DateTime.Now}
            };
            items.ForEach(i => context.Items.Add(i));

            context.SaveChanges();
        }

    }
}