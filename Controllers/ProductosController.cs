using Microsoft.AspNetCore.Mvc;

namespace Parcial1_P4_Camila.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                mensaje = "API funcionando correctamente",
                proyecto = "Parcial1_P4_Camila"
            });
        }
    }
}
