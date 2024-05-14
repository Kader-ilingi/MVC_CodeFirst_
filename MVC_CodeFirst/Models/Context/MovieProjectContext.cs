using Microsoft.EntityFrameworkCore;
using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Models.Context
{
    public class MovieProjectContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("server=DESKTOP-J4PTH70;database=MovieProjectDB;uid=sa;pwd=123;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(x => x.Title).HasMaxLength(255);
            modelBuilder.Entity<Movie>().Property(x => x.Description).HasMaxLength(500);

            //MovieGenre Id Customize
            modelBuilder.Entity<MovieGenre>().Ignore(x => x.ID);
            modelBuilder.Entity<MovieGenre>().HasKey(x => new { x.MovieId, x.GenreId });
            modelBuilder.Entity<MovieGenre>().HasOne(x => x.Movie).WithMany(x => x.MovieGenres).HasForeignKey(x => x.MovieId);
            //movie için ilişkilendirmeyi gerçekleştirdiğimizde Genre için otomatik ilişkiyi vermiş olacak.

            base.OnModelCreating(modelBuilder);
        }
    }   
}
