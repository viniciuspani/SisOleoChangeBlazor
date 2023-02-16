using Microsoft.EntityFrameworkCore;
using SisOleoChangeBlazor.Context;
using SisOleoChangeBlazor.Interface;
using SisOleoChangeBlazor.Modal;

namespace SisOleoChangeBlazor.Service
{
    public class OleoService : IOleoService
    {
        private readonly AppDbContext _context;

        public OleoService(AppDbContext context)
        {
            _context = context;
        }       

        public async Task<Oleo> CreateOleo(Oleo oleo)
        {
            try
            {
                _context.Oleos.Add(oleo);
                await _context.SaveChangesAsync();
                return oleo;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task<bool> DeleteOleo(int id)
        {
            try
            {
                var oleo = await _context.Oleos.FindAsync(id);
                _context.Oleos.Remove(oleo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Oleo> GetOleo(int id)
        {
            try
            {
                var oleo = await _context.Oleos.FindAsync(id);
                return oleo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Oleo>> GetOleos()
        {
            try
            {
                return await _context.Oleos.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> EditarOleo(int id, Oleo oleo)
        {
            try
            {
                _context.Entry(oleo).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
