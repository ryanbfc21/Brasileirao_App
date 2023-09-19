using AutoMapper;
using Brasileirao_App.Data;
using Brasileirao_App.Data.Dtos;
using Brasileirao_App.Models;
using Brasileirao_App.Repositories.Interfaces;

namespace Brasileirao_App.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly BrasileiraoContext _context;
        private IMapper _mapper;

        public JogadorRepository(BrasileiraoContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public void SalvarJogador(CreateJogadorDto jogadorDto)
        {
            Jogador jogador = _mapper.Map<Jogador>(jogadorDto);

            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
        }

    }
}
