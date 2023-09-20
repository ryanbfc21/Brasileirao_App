using Brasileirao_App.Data.Dtos;
using Brasileirao_App.Repositories;
using Brasileirao_App.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Brasileirao_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly IJogadorRepository _repository;

        public JogadorController(IJogadorRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult AdicionarJogador([FromBody] CreateJogadorDto jogadorDto)
        {
            _repository.SalvarJogador(jogadorDto);
            return Ok();
        }
    }
}
