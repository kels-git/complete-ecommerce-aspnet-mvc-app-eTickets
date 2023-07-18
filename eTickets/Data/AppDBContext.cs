using eTickets.Models;
using Microsoft.EntityFrameworkCore; 

namespace eTickets.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { 
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            //relationship one to many with the movie side
            modelBuilder.Entity<Actor_Movie>().HasOne(m =>  m.movie).WithMany(am => am.Actors_Movies).HasForeignKey(am => 
            am.MovieId);

            //relationship one to many with the actor side
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.actor).WithMany(am => am.Actors_Movies).HasForeignKey(am =>
            am.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        //table name
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }




    }
}
