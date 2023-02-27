using Microsoft.EntityFrameworkCore;
using SisOleoChangeBlazor.Context;
using SisOleoChangeBlazor.Interface;
using SisOleoChangeBlazor.Modal;

namespace SisOleoChangeBlazor.Service
{
    public class TrocaOleoService :ITrocaOleoService
    {
        private  readonly AppDbContext _context;

        public TrocaOleoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TrocaOleo> CreateTrocaOleo(TrocaOleo trocaOleo)
        {
            try
            {
                _context.TrocaOleos.Add(trocaOleo);
                await _context.SaveChangesAsync();
                return trocaOleo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  async Task<bool> DeleteTrocaOleo(int id)
        {
            try
            {
                var trocaOleo = await _context.TrocaOleos.FindAsync(id);
                _context.TrocaOleos.Remove(trocaOleo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task<bool> EditTrocaOleo(int id, TrocaOleo trocaOleo)
        {
            try
            {
                _context.Entry(trocaOleo).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<TrocaOleo> GetTrocaOleo(int id)
        {
            try
            {
                var trocaOleo = await _context.TrocaOleos.FindAsync(id);
                return trocaOleo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<TrocaOleo>> GetTrocaOleos()
        {
            try
            {
                return await _context.TrocaOleos.AsNoTracking().ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
