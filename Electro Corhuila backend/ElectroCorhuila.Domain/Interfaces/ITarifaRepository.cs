
using ElectroCorhuila.Domain.Entities;
using System.Threading.Tasks;

namespace ElectroCorhuila.Domain.Interfaces
{
    public interface ITarifaRepository
    {
        Task<Tarifa> GetPorEstratoAsync(int estrato);
        Task AddAsync(Tarifa tarifa);
    }
}
