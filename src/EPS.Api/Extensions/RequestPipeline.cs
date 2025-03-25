using EPS.Api.Middlewares;
using EPS.Domain.ApplicationUser;
using EPS.Infrastructure.DbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace EPS.Api.Extensions
{
    public static class RequestPipeline
    {
        public static async Task ConfigureRequestPipeline(this WebApplication app)
        {
            await Seed(app);
            app.UseSerilogRequestLogging();
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
            });

            if (!app.Environment.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            //app.UseMiddleware<AuthenticationDebugMiddleware>();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
        }

        public static async Task Seed(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                var dbContext = services.GetRequiredService<AppDbContext>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole<Guid>>>();
                //var encryptionService = services.GetRequiredService<IEncryptionService>();

                if (!await dbContext.ApplicationUsers.AnyAsync())
                {
                   // await SeedData.Seed(userManager, dbContext, roleManager, encryptionService);
                    await dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
