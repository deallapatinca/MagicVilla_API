using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
            new Villa
            {
                Id = 1,
                Name = "Royal Villa",
                Details = "Lorem whateevr this that",
                ImageUrl = "",
                Occupancy = 5,
                Rate = 200,
                Sqft = 550,
                Amenity = "",
                CreatedDate = DateTime.Now

            },
            new Villa
            {
                Id = 2,
                Name = "Royal Villa",
                Details = "Lorem whatever this that.",
                ImageUrl = "https://example.com/royal_villa.jpg",
                Occupancy = 5,
                Rate = 200,
                Sqft = 550,
                Amenity = "Pool, Garden, Spa",
                CreatedDate = DateTime.Now
            },
            new Villa
            {
                Id = 3,
                Name = "Mountain Retreat",
                Details = "A peaceful retreat in the mountains.",
                ImageUrl = "https://example.com/mountain_retreat.jpg",
                Occupancy = 4,
                Rate = 250,
                Sqft = 450,
                Amenity = "Sauna, Fireplace, Hiking Trails",
                CreatedDate = DateTime.Now
            },
            new Villa
            {
                Id = 4,
                Name = "Seaside Escape",
                Details = "Enjoy breathtaking ocean views.",
                ImageUrl = "https://example.com/seaside_escape.jpg",
                Occupancy = 6,
                Rate = 300,
                Sqft = 600,
                Amenity = "Beach Access, Hot Tub",
                CreatedDate = DateTime.Now
            },
            new Villa      
            {
                Id = 5,
                Name = "City Oasis",
                Details = "A luxurious villa in the heart of the city.",
                ImageUrl = "https://example.com/city_oasis.jpg",
                Occupancy = 3,
                Rate = 180,
                Sqft = 400,
                Amenity = "Gym, Rooftop Terrace, Bar",
                CreatedDate = DateTime.Now
            },
            new Villa
            {
                Id = 6,
                Name = "Desert Mirage",
                Details = "An exotic villa amidst the desert.",
                ImageUrl = "https://example.com/desert_mirage.jpg",
                Occupancy = 4,
                Rate = 220,
                Sqft = 500,
                Amenity = "Pool, Desert Safari, Star Gazing",
                CreatedDate = DateTime.Now
            },
            new Villa   
            {
                Id = 7,
                Name = "Forest Haven",
                Details = "A serene escape surrounded by nature.",
                ImageUrl = "https://example.com/forest_haven.jpg",
                Occupancy = 7,
                Rate = 275,
                Sqft = 650,
                Amenity = "Forest Trails, Yoga Studio",
                CreatedDate = DateTime.Now
            }

            );
        }
    }
}
