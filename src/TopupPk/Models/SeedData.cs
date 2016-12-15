using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace TopupPk.Models
{
    
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TopupPkContext(
                serviceProvider.GetRequiredService<DbContextOptions<TopupPkContext>>()))
            {
                
                if (context.Retailers.Any())
                {
                    return;
                }

                context.Retailers.AddRange(
                     new Retailer
                     {
                         Name = "Retailer 1",
                         Street = "Lucky Street",
                         City = "Chicago",
                         Country = "USA",
                         Phone = "+16785647766"
                     },

                     new Retailer
                     {
                         Name = "Retailer 2",
                         Street = "Wallace St",
                         City = "Blacktown",
                         Country = "Australia",
                         Phone = "+16785647766"
                     },

                     new Retailer
                     {
                         Name = "Retailer 3",
                         Street = "King Street",
                         City = "Sydney",
                         Country = "Australia",
                         Phone = "+16785647766"
                     },

                   new Retailer
                   {
                       Name = "Retailer 4",
                       Street = "Arnold Street",
                       City = "Atlanta",
                       Country = "USA",
                       Phone = "+16785647766"
                   }
                );
                context.SaveChanges();
            }
        }
    }

}
