using SisOleoChangeBlazor.Modal;

namespace SisOleoChangeBlazor.Interface
{
    public interface IOleoService
    {
        Task<List<Oleo>> GetOleos();
        Task<Oleo> GetOleo(int id);
        Task<Oleo> CreateOleo(Oleo oleo);
        Task<bool> DeleteOleo(int id);
        Task<bool> EditarOleo(int id, Oleo oleo);

        Task<List<Oleo>> GetTrocaOleoOl(int id);
    }
}
