using Microsoft.EntityFrameworkCore;
using SisOleoChangeBlazor.Context;
using SisOleoChangeBlazor.Interface;
using SisOleoChangeBlazor.Modal;

namespace SisOleoChangeBlazor.Service
{
    public class FiltroService : IFiltroService
    {
        private readonly AppDbContext _context;

        public FiltroService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Filtro> CreateFiltro(Filtro filtro)
        {
            try
            {
                _context.Filtros.Add(filtro);
                await _context.SaveChangesAsync();
                return filtro;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteFiltro(int id)
        {
            try
            {
                var oleo = await _context.Filtros.FindAsync(id);
                _context.Filtros.Remove(oleo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> EditarFiltro(int id, Filtro filtro)
        {
            try
            {
                _context.Entry(filtro).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Filtro>> GetFiltros()
        {
            try
            {
                return await _context.Filtros.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Filtro> GetFiltro(int id)
        {
            try
            {
                var filtro = await _context.Filtros.FindAsync(id);
                return filtro;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
