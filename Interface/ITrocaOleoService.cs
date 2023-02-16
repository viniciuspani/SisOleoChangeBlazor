using SisOleoChangeBlazor.Modal;

namespace SisOleoChangeBlazor.Interface
{
    public interface ITrocaOleoService
    {
        Task<List<TrocaOleo>> GetTrocaOleos();
        Task<TrocaOleo> GetTrocaOleo(int id);
        Task<TrocaOleo> CreateTrocaOleo(TrocaOleo trocaOleo);
        Task<bool> DeleteTrocaOleo(int id);
        Task<bool> EditTrocaOleo(int id, TrocaOleo trocaOleo);
    }
}
