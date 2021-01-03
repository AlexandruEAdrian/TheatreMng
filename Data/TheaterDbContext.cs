using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatreMng.Entities;
using Microsoft.EntityFrameworkCore;

namespace TheatreMng.Data
{
    public class TheaterDbContext :DbContext
    {
        public TheaterDbContext(DbContextOptions<TheaterDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Show> Shows { get; set; }
      
        public DbSet<ActorShow> ActorShows { get; set; }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Director>()
                .HasMany(x => x.Shows)
                .WithOne(x => x.Director)
                .HasForeignKey(x => x.DirectorId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Actor>()
                .HasMany(x => x.ActorShows)
                .WithOne(x => x.Actor)
                .HasForeignKey(x => x.ActorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Show>()
                .HasMany(x => x.ActorShows)
                .WithOne(x => x.Show)
                .HasForeignKey(x => x.ShowId)
                .OnDelete(DeleteBehavior.Cascade);

          
        }
    }
}
