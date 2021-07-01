using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<User>
                {
                    new User{
                        Id = "1",
                        UserName = "Admin",
                        Email = "admin@gmail.com"
                    },
                    new User{
                        Id = "2",
                        UserName = "User",
                        Email = "user@gmail.com"
                    }
                };
                foreach(var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }
        }
    }
}