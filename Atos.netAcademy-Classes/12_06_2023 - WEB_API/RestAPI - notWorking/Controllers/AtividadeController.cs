using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AtividadeController : ControllerBase
    {
        [HttpGet("retorna-nome")]
        public string Nome() 
        {
            return "Neil Angelo dos Santos";
        }
        
        [HttpGet("retorna-idade")]
        public string Idade()
        {
            return "29";
        }
        [HttpGet("retorna-nome/{nome}")]
        public string Nome2(string nome)
        {
            return nome;
        }
        [HttpGet("retorna-maioridade/{nome}/{idade}")]
        public string Maioridade(string nome, int idade)
        {
            return idade>18? nome + " é maior de idade": " Não é maior de idade";
        }
    }
}
