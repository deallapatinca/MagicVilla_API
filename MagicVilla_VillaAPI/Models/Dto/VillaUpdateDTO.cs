using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaUpdateDTO
    {
        [Required]

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public required string Name { get; set; }
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public int Sqft { get; set; }
        [Required]
        public required string Details { get; set; } 
        [Required]
        public double Rate { get; set; }
        [Required]
        public required string ImageUrl { get; set; } 
        [Required]
        public required string Amenity { get; set; } 
    }
}
