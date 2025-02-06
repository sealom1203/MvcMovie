using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "GP",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "GP",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Tangled",
                    ReleaseDate = DateTime.Parse("2010-11-14"),
                    Genre = "Animation",
                    Rating = "GP",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Baymax",
                    ReleaseDate = DateTime.Parse("2022-6-22"),
                    Genre = "Animation",
                    Rating = "GP",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Frozen",
                    ReleaseDate = DateTime.Parse("2013-11-19"),
                    Genre = "Animation",
                    Rating = "GP",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "Frozen 2",
                    ReleaseDate = DateTime.Parse("2019-11-7"),
                    Genre = "Animation",
                    Rating = "GP",
                    Price = 6.99M
                },
                new Movie
                {
                    Title = "Elemental",
                    ReleaseDate = DateTime.Parse("2023-6-16"),
                    Genre = "Animatin",
                    Rating = "gp",
                    Price = 7.99M
                }
            );
            context.SaveChanges();
        }
    }
}