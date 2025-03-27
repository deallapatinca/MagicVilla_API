using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public required string Name { get; set; } 

        public int Occupancy { get; set; }
        public int Sqft { get; set; }

        [Required]
        public required string Details { get; set; } 

        public double Rate { get; set; }

        [Required]
        public required string ImageUrl { get; set; } 

        [Required]
        public required string Amenity { get; set; } 
    }
}
