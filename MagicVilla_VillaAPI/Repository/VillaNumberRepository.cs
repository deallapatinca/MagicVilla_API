using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaNumberRepository : IVillaNumberRepository

    {
        private readonly ApplicationDBContext _db;
        public VillaNumberRepository(ApplicationDBContext db)
        {
            _db = db;
        }
        public async Task CreateAsync(VillaNumber entity)
        {
            await _db.VillaNumber.AddAsync(entity);
            await SaveAsync();

        }

        public async Task<VillaNumber> GetAsync(Expression<Func<VillaNumber, bool>> filter = null, bool tracked = true)
        {
            IQueryable<VillaNumber> query = _db.VillaNumber;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();

        }

        public async Task<List<VillaNumber>> GetAllAsync(Expression<Func<VillaNumber, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<VillaNumber> query = includeProperties==null? _db.VillaNumber: _db.VillaNumber.Include(includeProperties);
            
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();

        }

        public async Task RemoveAsync(VillaNumber entity)
        {
            _db.VillaNumber.Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumber.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
