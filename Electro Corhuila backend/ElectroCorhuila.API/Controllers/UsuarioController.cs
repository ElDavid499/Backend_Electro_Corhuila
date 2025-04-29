
using Microsoft.AspNetCore.Mvc;
using ElectroCorhuila.Application.DTOs;
using ElectroCorhuila.Application.Services;
using System.Threading.Tasks;

namespace ElectroCorhuila.API.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] UsuarioDto dto)
        {
            var result = await _usuarioService.CrearUsuarioAsync(dto);
            return Ok(result);
        }

        [HttpGet("{id}/tarifa")]
        public async Task<IActionResult> ObtenerTarifa(int id)
        {
            var valor = await _usuarioService.ObtenerTarifaPorUsuarioAsync(id);
            return Ok(new { Tarifa = valor });
        }
    }
}
