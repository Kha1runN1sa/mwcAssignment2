using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace mwcAssignment2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new mwcAssignment2Context(
                serviceProvider.GetRequiredService<DbContextOptions<mwcAssignment2Context>>()))
            {
                // Look for any movies.
                if (context.Blog.Any())
                {
                    return;   // DB has been seeded
                }

                context.Blog.AddRange(
                     new Blog
                     {
                         Author = "Bahit Hamid",
                         Article = "This is the first article, incomplete and missing other fields. You'll need to modify SeedData.cs according to Assignment specs."
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
