using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                try
                {

                    //Cinema
                    if (!context.Cinemas.Any())
                    {
                        context.Cinemas.AddRange(new List<Cinema>() {
                     new Cinema()
                     {
                         Name="Cinema 1",
                         Logo= "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                         Description="This is first description of the first cinema"
                     },
                       new Cinema()
                     {
                         Name="Cinema 2",
                         Logo= "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                         Description="This is second description of the second cinema"
                     },
                          new Cinema()
                     {
                         Name="Cinema 3",
                         Logo= "https://dotnethow.net/images/cinemas/cinema-3.jpeg",
                         Description="This is third description of the third cinema"
                     },
                          new Cinema()
                     {
                         Name="Cinema 4",
                         Logo= "https://dotnethow.net/images/cinemas/cinema-4.jpeg",
                         Description="This is fourth description of the fourth cinema"
                     },
                               new Cinema()
                     {
                         Name="Cinema 5",
                         Logo= "https://dotnethow.net/images/cinemas/cinema-5.jpeg",
                         Description="This is fifth description of the fifth cinema"
                     }

                    });
                        context.SaveChanges();
                    }

                    //Actors

                    if (!context.Actors.Any())
                    {
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is Bio of first Actor",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                         new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is Bio of second Actor",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                          new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is Bio of third Actor",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg"
                        },

                            new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is Bio of third Actor",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                              new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is Bio of third Actor",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-5.jpeg"
                        },

                    });
                        context.SaveChanges();
                    }


                    //Producers

                    if (!context.Producers.Any())
                    {
                        context.Producers.AddRange(new List<Producer>()
                    {
                         new Producer()
                        {
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-1.jpeg",
                            FullName = "Producer 1",
                            Bio = "This is Bio of first Producer",

                        },
                          new Producer()
                        {
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-2.jpeg",
                            FullName = "Producer 2",
                            Bio = "This is Bio of second Producer",
                        },
                            new Producer()
                        {
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-3.jpeg",
                            FullName = "Producer 3",
                            Bio = "This is Bio of third Producer",
                        },
                               new Producer()
                        {
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-4.jpeg",
                            FullName = "Producer 4",
                            Bio = "This is Bio of fourth Producer",
                        },
                                  new Producer()
                        {
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-5.jpeg",
                            FullName = "Producer 5",
                            Bio = "This is Bio of fifth Producer",
                        },
                    });
                        context.SaveChanges();

                    }

                    //Movies
                    if (!context.Movies.Any())
                    {
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is Life Movie Description Testing",
                            Price = 50.60,
                            ImageURL ="https://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Documentary
                        },
                         new Movie()
                        {
                            Name = "The ShawsShank Redemption",
                            Description = "This is ShawsShank Redemption movie description",
                            Price = 46.60,
                            ImageURL ="https://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                          new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is ghost movie description",
                            Price = 42.60,
                            ImageURL ="https://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                           new Movie()
                        {
                            Name = "Race",
                            Description = "This is Race movie description",
                            Price = 40.60,
                            ImageURL ="https://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(-10),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                              new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is Scoob Movie Description",
                            Price = 44.60,
                            ImageURL ="https://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Cartoon
                        },

                    });
                        context.SaveChanges();
                    }


                    //Actors and movies
                    if (!context.Actors_Movies.Any())
                    {
                        context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                           ActorId = 1,
                           MovieId = 2,
                        },
                         new Actor_Movie()
                        {
                           ActorId =2,
                           MovieId = 3,
                        },
                          new Actor_Movie()
                        {
                           ActorId = 2,
                           MovieId = 2,
                        },
                          new Actor_Movie()
                        {
                           ActorId = 1,
                           MovieId = 3,
                        },
                         new Actor_Movie()
                        {
                           ActorId = 3,
                           MovieId = 2,
                        },
                          new Actor_Movie()
                        {
                           ActorId = 2,
                           MovieId = 4,
                        },
                    });
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    var innerExceptionMessage = ex.InnerException?.Message;
                    Console.WriteLine($"Error occurred while saving entity changes-->: {innerExceptionMessage}");
                }

            }
          
        }

    }
}
