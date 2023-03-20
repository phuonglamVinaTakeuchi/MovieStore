namespace MovieStore.Data.SeedData
{
  public class AppDbInitializer
  {
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
      using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();

      var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

      if (context == null) return;

      context.Database.EnsureCreated();

      //Cinema
      if (!context.Cinemas.Any())
      {
        context.Cinemas.AddRange(CollectionExtension.CreateCinemas().ToList());
        context.SaveChanges();
      }

      //Actors
      if (!context.Actors.Any())
      {
        context.Actors.AddRange(CollectionExtension.CreateActors().ToList());
        context.SaveChanges();
      }

      //Producers
      if (!context.Producers.Any())
      {
        context.Producers.AddRange(CollectionExtension.CreateProducers().ToList());
        context.SaveChanges();
      }

      //MovieCategory
      if (!context.MovieCategories.Any())
      {
        context.MovieCategories.AddRange(CollectionExtension.CreateMovieCategories());
        context.SaveChanges();
      }

      //Movies
      if (!context.Movies.Any())
      {
        context.Movies.AddRange(CollectionExtension.CreateMovies());
        context.SaveChanges();
      }

      //Actors & Movies
      if (!context.MoviesActors.Any())
      {
        context.MoviesActors.AddRange(CollectionExtension.CreateMoviesActors());
        context.SaveChanges();
      }

      // Save changes to database when all data is seeded
      //context.SaveChanges();
    }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {

        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //        string adminUserEmail = "admin@etickets.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if(adminUser == null)
        //        {
        //            var newAdminUser = new ApplicationUser()
        //            {
        //                FullName = "Admin User",
        //                UserName = "admin-user",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }


        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new ApplicationUser()
        //            {
        //                FullName = "Application User",
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
        //    }
        //}
  }
}
