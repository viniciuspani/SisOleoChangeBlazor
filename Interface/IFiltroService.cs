using SisOleoChangeBlazor.Modal;

namespace SisOleoChangeBlazor.Interface
{
    public interface IFiltroService
    {
        Task<List<Filtro>> GetFiltros();
        Task<Filtro> GetFiltro(int id);
        Task<Filtro> CreateFiltro(Filtro filtro);
        Task<bool> DeleteFiltro(int id);
        Task<bool> EditarFiltro(int id, Filtro filtro);
    }
}
