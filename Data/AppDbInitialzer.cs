using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Data.Models;

namespace TestApi.Data
{
    public class AppDbInitialzer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Description",
                        isRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Description",
                        isRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
