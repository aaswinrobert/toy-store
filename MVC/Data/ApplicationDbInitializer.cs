using MVC.Data.Static;
using MVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();
 
                if (!context.Toys.Any())
                {
                    context.Toys.AddRange(new List<Toys>()
                    {
                        new Toys()
                        {
                            ToyName = "Dancing Robo",
                            ToyDescription = "Sky Blue Dancing Robo",
                            ToyPrice = 2800,
                            ToyImageURL = "../Images/Robos/Dancing Robo.jpeg",
                            ToyCategory = ToyCategory.Transformers,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Joy Stick Boxing Robo Ring",
                            ToyDescription = "Robos Fighthing In a Ring",
                            ToyPrice = 4500,
                            ToyImageURL = "../Images/Robos/Joy Stick Boxing Robo Ring.jpg",
                            ToyCategory = ToyCategory.Transformers,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Remote COntrol DOg",
                            ToyDescription = "Remote Control Robo Dog",
                            ToyPrice = 1900,
                            ToyImageURL = "../Images/Robos/Remote COntrol DOg.jpg",
                            ToyCategory = ToyCategory.Transformers,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Robo Transformer",
                            ToyDescription = "Large Yellow Robo Transformer !",
                            ToyPrice = 4500,
                            ToyImageURL = "../Images/Robos/Robo Transformer.jpg",
                            ToyCategory = ToyCategory.Transformers,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Walong RObo Blue",
                            ToyDescription = "Blue Walong Robo Dancing !",
                            ToyPrice = 2300,
                            ToyImageURL = "../Images/Robos/Walong RObo Blue.jpeg",
                            ToyCategory = ToyCategory.Transformers,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Baby Harris Hippo",
                            ToyDescription = "Stuffed Baby Harris Hippo",
                            ToyPrice = 1200,
                            ToyImageURL = "../Images/Stuffed Toys/Baby Harris Hippo.jpg",
                            ToyCategory = ToyCategory.Paw_Patrol,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Sitting Soft Cat",
                            ToyDescription = "Soft Sitting Cat!",
                            ToyPrice = 1500,
                            ToyImageURL = "../Images/Stuffed Toys/Sitting Soft Cat.jpg",
                            ToyCategory = ToyCategory.Peppa_Pig,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Squiahmallow",
                            ToyDescription = "Sqeazing Marshmallow",
                            ToyPrice = 1150,
                            ToyImageURL = "../Images/Stuffed Toys/Squiahmallow.jpg",
                            ToyCategory = ToyCategory.Peppa_Pig,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Unicorn",
                            ToyDescription = "Pastel Blue Unicorn with Rainbow Tail",
                            ToyPrice = 1250,
                            ToyImageURL = "../Images/Stuffed Toys/Unicorn.jpg",
                            ToyCategory = ToyCategory.Paw_Patrol,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Winnie the Pooh and Friends",
                            ToyDescription = "Group of Winnie The Pooh and Friends",
                            ToyPrice = 4500,
                            ToyImageURL = "../Images/Stuffed Toys/Winnie the Pooh and Friends.jpg",
                            ToyCategory = ToyCategory.Paw_Patrol,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Light Up Red Monster Truck",
                            ToyDescription = "Monster Truck with lighted wheels",
                            ToyPrice = 2000,
                            ToyImageURL = "../Images/Wheely Toys/Light Up Red Monster Truck.jpeg",
                            ToyCategory = ToyCategory.Transformers,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Rage Truck",
                            ToyDescription = "Orange Rage Trucks with Large Wheels",
                            ToyPrice = 1300,
                            ToyImageURL = "../Images/Wheely Toys/Rage Truck.jpeg",
                            ToyCategory = ToyCategory.Harry_Potter,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Red Tow Truck",
                            ToyDescription = "Red Colored Tow Truck",
                            ToyPrice = 1100,
                            ToyImageURL = "../Images/Wheely Toys/Red Tow Truck.jpeg",
                            ToyCategory = ToyCategory.Harry_Potter,
                            Availability = "Available"

                        },
                        new Toys()
                        {
                            ToyName = "Remote COntrol Car",
                            ToyDescription = "Red-colored Remote control Car",
                            ToyPrice = 899,
                            ToyImageURL = "../Images/Wheely Toys/Remote COntrol Car.jpg",
                            ToyCategory = ToyCategory.Disney_Princess,
                            Availability = "Available"

                        },
                    });
                    context.SaveChanges();
                }

                
                if (!context.ToyItems.Any())
                {


                }

            }


        }

        

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "aaswin@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Aaswin Robert",
                        UserName = "Admin_Aaswin_Robert",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Aaswin@123");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "aaswin@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Aaswin Robert",
                        UserName = "User_Aaswin_Robert",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Aaswin@123");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}

