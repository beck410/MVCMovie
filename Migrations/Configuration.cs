namespace MVCMovie.Migrations
{
  using MVCMovie.Models;
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCMovie.Models.MVCMovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCMovie.Models.MVCMovieContext context)
        {
          context.Movies.AddOrUpdate(i => i.Title,
            new Movie {
              Title = "When Harry Met Sally",
              ReleaseDate = DateTime.Parse("1989-1-11"),
              Genre = "Romantic Comedy",
              Rating = "M",
              Price = 7.99M,
              Razzie = false
            },

            new Movie {
              Title = "Ghostbusters ",
              ReleaseDate = DateTime.Parse("1984-3-13"),
              Genre = "Comedy",
              Rating = "PG",
              Price = 8.99M,
              Razzie = false
            },

            new Movie {
              Title = "Ghostbusters 2",
              ReleaseDate = DateTime.Parse("1986-2-23"),
              Genre = "Comedy",
              Rating = "PG",
              Price = 9.99M,
              Razzie = false
            },

            new Movie {
              Title = "Rio Bravo",
              ReleaseDate = DateTime.Parse("1959-4-15"),
              Genre = "Western",
              Rating = "G",
              Price = 3.99M,
              Razzie = false
            },

            new Movie {
              Title = "Terminator",
              ReleaseDate = DateTime.Parse("1980-4-15"),
              Genre = "Action",
              Rating = "M",
              Price = 7.99M,
              Razzie = false
            }
          );
        }
    }
}
