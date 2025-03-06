using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; }
    }
}
