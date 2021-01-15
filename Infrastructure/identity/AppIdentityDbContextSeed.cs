using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Core.Entities.Identity;
using System.Linq;

namespace Infrastructure.identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any()) {
                var user = new AppUser{
                    DisplayName ="Bob",
                    Email= "bob@test.com",  
                    UserName = "bob@test.com",
                    Address = new Address{
                        FirstName = "Bob",
                        LastName = "Bobbitt",
                        Street = "10 No Where Street",
                        City = "New York",
                        State = "NY",
                        Zipcode = "90210"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}