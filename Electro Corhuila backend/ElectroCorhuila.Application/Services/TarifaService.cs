
using ElectroCorhuila.Application.DTOs;
using ElectroCorhuila.Domain.Entities;
using ElectroCorhuila.Domain.Interfaces;
using System.Threading.Tasks;

namespace ElectroCorhuila.Application.Services
{
    public class TarifaService
    {
        private readonly ITarifaRepository _tarifaRepo;

        public TarifaService(ITarifaRepository tarifaRepo)
        {
            _tarifaRepo = tarifaRepo;
        }

        public async Task<TarifaDto> CrearTarifaAsync(TarifaDto dto)
        {
            var tarifa = new Tarifa
            {
                Estrato = dto.Estrato,
                Valor = dto.Valor
            };
            await _tarifaRepo.AddAsync(tarifa);
            return dto;
        }
    }
}
