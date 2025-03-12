using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    // Static class to serve as an in-memory store for villa data
    public static class VillaStore
    {
        // Static list that holds the villa data, initialized with some sample values
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
        new VillaDTO
    {
        Id = 1,
        Name = "Luxury Villa",
        Details = "A beautiful luxury villa.",
        Rate = 200.0,
        Sqft = 1500,
        Occupancy = 4,
        ImageUrl = "https://example.com/image1.jpg",
        Amenity = "Pool, Garden"
    },
    new VillaDTO
    {
        Id = 2,
        Name = "Modern Villa",
        Details = "A modern villa with a stunning view.",
        Rate = 300.0,
        Sqft = 1800,
        Occupancy = 6,
        ImageUrl = "https://example.com/image2.jpg",
        Amenity = "Sauna, Gym"
    }
        };
    }
}
