using SisOleoChangeBlazor.Modal;

namespace SisOleoChangeBlazor.Interface
{
    public interface IVeiculoService
    {
        Task<List<Veiculo>> GetVeiculos();
        Task<Veiculo> GetVeiculo(int id);
        Task<Veiculo> CreateVeiculo(Veiculo veiculo);
        Task<bool> DeleteVeiculo(int id);
        Task<bool> EditarVeiculo(int id, Veiculo veiculo);
    }
}
