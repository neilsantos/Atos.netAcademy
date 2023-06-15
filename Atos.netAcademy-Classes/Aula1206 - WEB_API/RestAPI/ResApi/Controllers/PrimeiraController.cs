using Microsoft.AspNetCore.Mvc;

namespace ResApi.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class PrimeiraController : ControllerBase
    {
        [HttpGet("primeiro")]
        public string pirmeiroEndPoint()
        {
            return "AUla de restapi";   
        }

    }
}
