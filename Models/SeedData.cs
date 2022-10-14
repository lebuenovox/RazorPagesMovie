using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Os Vingadores",
                        ReleaseDate = DateTime.Parse("2012-2-12"),
                        Genre = "Action",
                        Price = 7.99M,
                        Rating = "Rt"
                    },

                    new Movie
                    {
                        Title = "Vingadores: Era de Ultron ",
                        ReleaseDate = DateTime.Parse("2015-3-13"),
                        Genre = "Action",
                        Price = 8.99M,
                        Rating = "Rt"
                    },

                    new Movie
                    {
                        Title = "Vingadores Guerra Infinita",
                        ReleaseDate = DateTime.Parse("2018-2-23"),
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "Rt"
                    },

                    new Movie
                    {
                        Title = "Vingadores Ultimato",
                        ReleaseDate = DateTime.Parse("2019-4-15"),
                        Genre = "Action",
                        Price = 3.99M,
                        Rating = "Rt"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}