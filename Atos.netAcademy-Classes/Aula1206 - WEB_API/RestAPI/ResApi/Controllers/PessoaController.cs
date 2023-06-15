using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResApi.DataModels;

namespace ResApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> getAllAsync([FromServices] Contexto contexto)
        {
            var pessoas = await contexto
                .Pessoas
                .AsNoTracking()//só para consultar - recomendado por alto desempenho
                .ToListAsync();

            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getByIdAsync([FromServices] Contexto contexto,[FromRoute] int id)
        {
            var pessoas = await contexto
                .Pessoas
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);

            return pessoas == null ? NotFound() : Ok(pessoas);
        }
      
        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> PostAsync([FromServices] Contexto contexto,[FromBody] Pessoa pessoa)
        {
            //veirifica se os atributos da model esta valido
          //  if(!ModelState.IsValid) return BadRequest();

            try
            {
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();
                return Created($"api/pessoas/{pessoa.Id}", pessoa);

            }
            catch(Exception ex) { return BadRequest(ex.Message); }
            
        }
        
        [HttpPut]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> PutAsync([FromServices] Contexto contexto,[FromBody] Pessoa pessoa,[FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest();
            var p = await contexto.Pessoas
                .FirstOrDefaultAsync(x => x.Id == id);
            if (p == null)
                return NotFound("Pessoa não encontrada!");

            try
            {
                p.Nome = pessoa.Nome;

                contexto.Pessoas.Update(p);
                await contexto.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
       
        [HttpDelete]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> DeleteAsync([FromServices] Contexto contexto,[FromRoute] int id)
        {
            var p = await contexto.Pessoas
                .FirstOrDefaultAsync(x => x.Id == id);

            if (p == null)
                return NotFound("Pessoa não encontrada!");

            try
            {
                
                contexto.Pessoas.Remove(p);
                await contexto.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpPost]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> CadastrarEmailPessoa([FromServices] Contexto contexto,[FromBody] Email email,[FromRoute] int id)
        {
            var pessoa = await contexto
                .Pessoas.AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);

            email.Pessoa= pessoa;

            try
            {
                contexto.Set<Email>().Add(email);
                contexto.Entry(email.Pessoa).State = EntityState.Unchanged;
                await contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return Created($"Pessoa/pessoas/{pessoa.Id}", email);
        }

    }//Controller

    
    
}

