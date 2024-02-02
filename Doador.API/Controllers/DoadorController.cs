using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorservice;
        public DoadorController(IDoadorService doadorservice)
        {
            _doadorservice = doadorservice;
        }
        [HttpPost]
        [Route("CadastrarDoador")]
        public async Task<IActionResult> PostAsync([FromBody] DoadorCommand command)
        {

            return Ok(await _doadorservice.PostAsync(command));
        }
    }
}