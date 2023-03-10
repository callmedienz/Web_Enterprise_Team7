using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.QaManagment.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.QmManagment.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Staff.ToString()));
        }
        public static async Task AdminAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new User
            {
                UserName = "admin",
                Email = "locntgbh18350@fpt.edu.vn",
                FirstName = "Loc",
                LastName = "Nguyen",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Staff.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.QmManagment.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.QaManagment.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Admin.ToString());
                }
            }
        }
    }
}
