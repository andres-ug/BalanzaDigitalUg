using Microsoft.AspNetCore.Identity;

namespace BalanzaDigitalUg.Web.Data;

public static class IntiialData
{
    public static async Task SeedUsersAsync(IServiceProvider serviceProvider)
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        var user1 = new ApplicationUser
            { Id = 1.ToString(), UserName = "admin@example.com", Email = "admin@example.com", EmailConfirmed = true };
        var user2 = new ApplicationUser
            { Id = 2.ToString(), UserName = "user@example.com", Email = "user@example.com", EmailConfirmed = true };

        if (await userManager.FindByEmailAsync(user1.Email) == null)
            await userManager.CreateAsync(user1, "Admin123!");

        if (await userManager.FindByEmailAsync(user2.Email) == null)
            await userManager.CreateAsync(user2, "User123!");
    }
}