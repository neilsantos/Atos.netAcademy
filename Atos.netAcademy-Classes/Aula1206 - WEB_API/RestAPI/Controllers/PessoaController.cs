using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using RestAPI.DataModels;
using RestAPI;


namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> getAllAsync([FromServices] Contexto contexto) 
        {
            var pessoas = await contexto
                .Pessoas
                .AsNoTracking()
                .ToListAsync();

            return pessoas == null ?  NotFound() : Ok(pessoas); 
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getAllAsync([FromServices] Contexto contexto, int id)
        {
            var pessoas = await contexto
                .Pessoas.AsNoTracking()
                .FirstOrDefaultAsync(p=>p.Id == id);

            return pessoas == null ? NotFound() : Ok(pessoas);
        }
        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> PostAsync([FromServices] Contexto contexto, [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                await contexto.Pessoas.AddAsync(pessoa); 
                await contexto.SaveChangesAsync();
                return Created($"pessoa/pessoas/{pessoa.Id}", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
        }
            

    }
}
