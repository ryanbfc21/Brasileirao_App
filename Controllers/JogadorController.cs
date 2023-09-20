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

        [HttpGet]
        public IEnumerable<ReadJogadorDto> RecuperarJogadores([FromQuery] int skip = 0, [FromQuery] int take = 1000)
        {
            var listJogadores = _repository.ListarJogadores(skip, take);

            return listJogadores;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarJogadorPorId(int id)
        {
            var jogador = _repository.BuscarJogadorPorId(id);

            if (jogador != null)
            {
                return Ok(jogador);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarJogador(int id, [FromBody] UpdateJogadorDto filmeDto)
        {
            bool atualizado = _repository.AtualizarJogador(id, filmeDto);

            if (atualizado)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarJogador(int id)
        {
            bool deletado = _repository.DeletarJogador(id);

            if (deletado)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

    }
}
