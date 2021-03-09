using Microsoft.AspNetCore.Identity;
using PhysicalTherapyProject.Domain.Models;

namespace PhysicalTherapyProject.Persistance.Infrastructure
{
    public static class IdentitySeeder
    {
        public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByNameAsync("admin@gmail.com").Result == null)
            {
                var user = new ApplicationUser
                {
                    Name="Vardenis",
                    Surname="Pavardenis",
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    NormalizedUserName = "ADMIN",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    OccupationId = 1
                };

                var password = "password";

                var createUser = userManager.CreateAsync(user, password).Result;

                if (createUser.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administratorius").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<ApplicationRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administratorius").Result)
            {
                var role = new ApplicationRole
                {
                    Name = "Administratorius"
                };
                roleManager.CreateAsync(role).Wait();
            }
            if (!roleManager.RoleExistsAsync("Naudotojas").Result)
            {
                var role = new ApplicationRole
                {
                    Name = "Naudotojas"
                };
                roleManager.CreateAsync(role).Wait();
            }
            if (!roleManager.RoleExistsAsync("Registruotas naudotojas").Result)
            {
                var role = new ApplicationRole
                {
                    Name = "Registruotas naudotojas"
                };
                roleManager.CreateAsync(role).Wait();
            }
        }
    }
}