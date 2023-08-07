using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HairSalon.Models
{
    public static class DataInitializer
    {
        public static void InitializeData(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<HairSalonContext>();
                context.Database.Migrate();

                if (!context.Stylists.Any())
                {
                    // Add 4 stylists.
                    var stylists = new Stylist[]
                    {
                        new Stylist { Name = "Fluffy Blubberworth", Specialty = "Fluffy hair", Wage = 15.15m.ToString() },
                        new Stylist { Name = "Brayan Macias", Specialty = "Green Eye's", Wage = 20.20m.ToString() },
                        new Stylist { Name = "Haylee Clayton", Specialty = "Curly Hair", Wage = 31.15m.ToString() },
                        new Stylist { Name = "Russell Small", Specialty = "Blue Eye's", Wage = 18.95m.ToString() }
                    };

                    context.Stylists.AddRange(stylists);
                    context.SaveChanges();

                    // For each stylist, add 3 clients with unique names.
                    int clientCounter = 1;
                    foreach (var stylist in stylists)
                    {
                        context.Clients.AddRange(
                            new Client { Name = "Client " + clientCounter++, StylistId = stylist.StylistId },
                            new Client { Name = "Client " + clientCounter++, StylistId = stylist.StylistId },
                            new Client { Name = "Client " + clientCounter++, StylistId = stylist.StylistId }
                        );
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
