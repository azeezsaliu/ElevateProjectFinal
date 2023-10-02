using Microsoft.AspNetCore.Identity;

namespace ElevateProjectFinal.Models
{
    public class IdentitySeedData
    {
        public static void CreateAdminAccount(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            CreateAdminAccountAsync(serviceProvider, configuration).Wait();
        }

        public static async Task CreateAdminAccountAsync(IServiceProvider
serviceProvider, IConfiguration configuration)
        {
            serviceProvider = serviceProvider.CreateScope().ServiceProvider;

            UserManager<User> userManager =
            serviceProvider.GetRequiredService<UserManager<User>>();
            
            RoleManager<IdentityRole> roleManager =
            serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            
            string username = "admin";
            string email = "admin@example.com";
            string password = "secret";
            string role = "Admin";
            if (await userManager.FindByNameAsync(username) == null)
            {
                
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                    await roleManager.CreateAsync(new IdentityRole("Student"));
                    await roleManager.CreateAsync(new IdentityRole("Instructor"));
                }

                User user = new User
                {
                    UserName = username,
                    Email = email,
                    Password = password
                    //Role = role
                };
                IdentityResult result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
