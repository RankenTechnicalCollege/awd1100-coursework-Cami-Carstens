using CRUDUsers.Data;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using CRUDUsers.Models;


namespace CRUDUsers
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddDbContext<DataContext>(
               options =>
               {
                   var dbPath = Path.Combine(FileSystem.AppDataDirectory, "users.db");
                    options.UseSqlite($"Data Source={dbPath}");
               }
                );
            //dependency injection-allows us to inject dependencies into classes, rather than hard coding them(automatically) 

#if DEBUG
            builder.Logging.AddDebug();
#endif
            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DataContext>();
                context.Database.EnsureCreated(); //creates the database if it does not exist

                if(!context.Users.Any()) //Any returns users if they exist
                {
                    context.Users.AddRange(
                        new User { Name= "Alice" },
                        new User { Name = "Bob" },
                        new User { Name = "Charlie" }
                        );
                    context.SaveChanges(); //saves the changes to the database
                }
            }
            return app;
            
        }
    }
}
