
using ElectroCorhuila.Domain.Entities;
using ElectroCorhuila.Domain.Interfaces;
using ElectroCorhuila.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ElectroCorhuila.Infrastructure.Repositories
{
    public class TarifaRepository : ITarifaRepository
    {
        private readonly AppDbContext _context;

        public TarifaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Tarifa tarifa)
        {
            _context.Tarifas.Add(tarifa);
            await _context.SaveChangesAsync();
        }

        public async Task<Tarifa> GetPorEstratoAsync(int estrato)
        {
            return await _context.Tarifas.FirstOrDefaultAsync(t => t.Estrato == estrato);
        }
    }
}
