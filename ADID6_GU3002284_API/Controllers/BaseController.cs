using ADID6_GU3002284_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ADID6_GU3002284_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
        protected async Task<IActionResult> TratarResultadoAsync(Func<Task<IActionResult>> servico)
        {
            try
            {
                return await servico();
            }
            catch (Exception)
            {                
                return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro no servidor!");
            }
        }
    }
}
