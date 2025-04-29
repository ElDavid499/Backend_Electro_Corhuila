
using Microsoft.AspNetCore.Mvc;
using ElectroCorhuila.Application.DTOs;
using ElectroCorhuila.Application.Services;
using System.Threading.Tasks;

namespace ElectroCorhuila.API.Controllers
{
    [ApiController]
    [Route("api/tarifas")]
    public class TarifaController : ControllerBase
    {
        private readonly TarifaService _tarifaService;

        public TarifaController(TarifaService tarifaService)
        {
            _tarifaService = tarifaService;
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] TarifaDto dto)
        {
            var result = await _tarifaService.CrearTarifaAsync(dto);
            return Ok(result);
        }
    }
}
