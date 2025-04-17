using System;
using Microsoft.Extensions.DependencyInjection;
using sportx_api.Models;
using sportx_api.Utils;

namespace sportx_api
{
    public class AdminPasswordResetRunner
    {
        public static void Run(IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<MyDbContext>();
                try
                {
                    AdminPasswordReset.ResetInitialAdminPassword(db, "itech0785@gmail.com", "Admin@123");
                    Console.WriteLine("Admin password reset to Admin@123");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Admin password reset error: {ex.Message}");
                }
            }
        }
    }
}
