using Microsoft.EntityFrameworkCore;
using SisOleoChangeBlazor.Context;
using SisOleoChangeBlazor.Interface;
using SisOleoChangeBlazor.Modal;

namespace SisOleoChangeBlazor.Service
{
    public class VeiculoService : IVeiculoService
    {
        private readonly AppDbContext _context;

        public VeiculoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Veiculo>> GetVeiculos()
        {
            try
            {
                               
                return await _context.Veiculos.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task<Veiculo> GetVeiculo(int id)
        {
            try
            {
                var veiculo = await _context.Veiculos.FindAsync(id);
                return veiculo;
            }
            catch (Exception)
            {

                throw;
            }         
        }

        public async Task<Veiculo> CreateVeiculo(Veiculo veiculo)
        {
            try
            {
                _context.Veiculos.Add(veiculo);
                await _context.SaveChangesAsync();
                return veiculo;
            }
            catch (Exception)
            {
                throw;
            }
            

        }

        public async Task<bool> DeleteVeiculo(int id)
        {
            try
            {
                var veiculo = await _context.Veiculos.FindAsync(id);
                _context.Veiculos.Remove(veiculo);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {               
                throw;
            }
        }

        public async Task<bool> EditarVeiculo(int id, Veiculo veiculo)
        {
            try
            {             
                _context.Entry(veiculo).State = EntityState.Modified;
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
