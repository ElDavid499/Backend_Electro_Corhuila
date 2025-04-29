
using ElectroCorhuila.Domain.Interfaces;
using ElectroCorhuila.Application.DTOs;
using ElectroCorhuila.Domain.Entities;
using System.Threading.Tasks;

namespace ElectroCorhuila.Application.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepo;
        private readonly ITarifaRepository _tarifaRepo;

        public UsuarioService(IUsuarioRepository usuarioRepo, ITarifaRepository tarifaRepo)
        {
            _usuarioRepo = usuarioRepo;
            _tarifaRepo = tarifaRepo;
        }

        public async Task<UsuarioDto> CrearUsuarioAsync(UsuarioDto dto)
        {
            var usuario = new Usuario
            {
                Nombre = dto.Nombre,
                Documento = dto.Documento,
                Direccion = dto.Direccion,
                Estrato = dto.Estrato
            };
            await _usuarioRepo.AddAsync(usuario);
            return dto;
        }

        public async Task<decimal> ObtenerTarifaPorUsuarioAsync(int usuarioId)
        {
            var usuario = await _usuarioRepo.GetByIdAsync(usuarioId);
            var tarifa = await _tarifaRepo.GetPorEstratoAsync(usuario.Estrato);
            return tarifa.Valor;
        }
    }
}
