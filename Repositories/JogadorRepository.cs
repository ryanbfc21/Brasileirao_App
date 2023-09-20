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

        public IEnumerable<ReadJogadorDto> ListarJogadores(int skip, int take)
        {
            IEnumerable<Jogador> jogadores = _context.Jogadores.Skip(skip).Take(take).ToList();

            var jogadoresDto = _mapper.Map<IEnumerable<ReadJogadorDto>>(jogadores);

            return jogadoresDto;

        }

        public ReadJogadorDto BuscarJogadorPorId(int id)
        {
            var jogador = this.FindJogador(id);

            var jogadorDto = _mapper.Map<ReadJogadorDto>(jogador);
            
            return jogadorDto;
        }

        public bool AtualizarJogador(int id, UpdateJogadorDto jogadorDto)
        {
            var jogador = this.FindJogador(id);

            if (jogador != null)
            {
                _mapper.Map(jogadorDto, jogador);

                _context.SaveChanges();

                return true;
            }
            return false;
        }

        public bool DeletarJogador(int id)
        {
            var jogador = this.FindJogador(id);

            if(jogador != null)
            {
                _context.Jogadores.Remove(jogador);
                _context.SaveChanges(true);
                return true;
            }
            return false;
        }

        public Jogador FindJogador(int id)
        {
            var jogador = _context.Jogadores.FirstOrDefault(j => j.Id == id);
            return jogador;
        }

    }
}
