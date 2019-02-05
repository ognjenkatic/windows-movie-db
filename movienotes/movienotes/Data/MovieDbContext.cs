using Microsoft.EntityFrameworkCore;
using movienotes.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Award> Award { get; set; }
        public DbSet<ArtistMember> ArtistMember { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<CrewMember> CrewMember { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieAward> MovieAward { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<MovieSong> MovieSong { get; set; }
        public DbSet<Quote> Quote { get; set; }
        public DbSet<TrailerLink> TrailerLink { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<CastMember> CastMember { get; set; }
        public DbSet<Rating> Rating { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBUilder)
        {
            optionsBUilder.UseSqlite($"Filename = mnotes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieAward>()
                .HasKey(ma => new { ma.AwardID, ma.MovieID });

            modelBuilder.Entity<MovieAward>()
                .HasOne(ma => ma.Movie)
                .WithMany(mo => mo.MovieAwards)
                .HasForeignKey(ma => ma.MovieID);

            modelBuilder.Entity<MovieAward>()
                .HasOne(ma => ma.Award)
                .WithMany(aw => aw.AwardMovies)
                .HasForeignKey(ma => ma.AwardID);

            modelBuilder.Entity<ArtistMember>()
                .HasKey(am => new { am.ArtistID, am.PersonID });

            modelBuilder.Entity<ArtistMember>()
                .HasOne(am => am.Artist)
                .WithMany(ar => ar.ArtistMemberships)
                .HasForeignKey(am => am.ArtistID);

            modelBuilder.Entity<ArtistMember>()
                .HasOne(am => am.Person)
                .WithMany(pe => pe.ArtistMemberships)
                .HasForeignKey(am => am.PersonID);

            modelBuilder.Entity<CastMember>()
                .HasKey(cm => new { cm.MovieID, cm.PersonID });

            modelBuilder.Entity<CastMember>()
                .HasOne(cm => cm.Movie)
                .WithMany(mo => mo.CastMembers)
                .HasForeignKey(cm => cm.MovieID);

            modelBuilder.Entity<CastMember>()
                .HasOne(cm => cm.Person)
                .WithMany(mo => mo.CastMemberships)
                .HasForeignKey(cm => cm.PersonID);

            modelBuilder.Entity<CrewMember>()
                .HasKey(cm => new { cm.PersonID, cm.MovieID});

            modelBuilder.Entity<CrewMember>()
                .HasOne(cm => cm.Movie)
                .WithMany(mo => mo.CrewMembers)
                .HasForeignKey(cm => cm.MovieID);

            modelBuilder.Entity<CrewMember>()
                .HasOne(cm => cm.Person)
                .WithMany(mo => mo.CrewMemberships)
                .HasForeignKey(cm => cm.PersonID);

            modelBuilder.Entity<Movie>()
                .HasOne(m => m.Rating)
                .WithMany(ra => ra.Movies)
                .HasForeignKey(m => m.RatingID);

            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new { mg.MovieID, mg.GenreID });

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(mo => mo.MovieGenres)
                .HasForeignKey(mg => mg.MovieID);

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(ge => ge.MovieGenres)
                .HasForeignKey(mg => mg.GenreID);

            modelBuilder.Entity<MovieSong>()
                .HasKey(ms => new { ms.MovieID, ms.ArtistID });

            modelBuilder.Entity<MovieSong>()
                .HasOne(ms => ms.Movie)
                .WithMany(mo => mo.MovieSongs)
                .HasForeignKey(ms => ms.MovieID);

            modelBuilder.Entity<MovieSong>()
                .HasOne(ms => ms.Artist)
                .WithMany(ar => ar.MovieSongs)
                .HasForeignKey(ms => ms.ArtistID);
            
            modelBuilder.Entity<TrailerLink>()
                .HasOne(tl => tl.Movie)
                .WithMany(mo => mo.TrailerLinks)
                .HasForeignKey(tl => tl.MovieID);
        }
    }
}

