using Microsoft.AspNetCore.Mvc;

namespace Parcial1_P4_Camila.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberController : ControllerBase
    {
        // Endpoint: api/number/{numero}
        [HttpGet("{numero}")]
        public IActionResult SumarMismoNumero(double numero)
        {
            double resultado = numero + numero;
            return Ok(new { original = numero, resultado = resultado });
        }
    }
}
