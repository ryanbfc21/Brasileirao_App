using Brasileirao_App.Data.Dtos;

namespace Brasileirao_App.Repositories.Interfaces
{
    public interface IJogadorRepository
    {
        void SalvarJogador(CreateJogadorDto jogadorDto);
        IEnumerable<ReadJogadorDto> ListarJogadores(int skip, int take);
        ReadJogadorDto BuscarJogadorPorId(int id);
        bool AtualizarJogador(int id, UpdateJogadorDto jogadorDto);
        bool DeletarJogador(int id);
    }
}
