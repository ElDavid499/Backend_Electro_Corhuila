
using ElectroCorhuila.Domain.Entities;
using System.Threading.Tasks;

namespace ElectroCorhuila.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task AddAsync(Usuario usuario);
        Task<Usuario> GetByIdAsync(int id);
    }
}
