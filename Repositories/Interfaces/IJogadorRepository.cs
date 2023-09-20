using Brasileirao_App.Data.Dtos;

namespace Brasileirao_App.Repositories.Interfaces
{
    public interface IJogadorRepository
    {
        void SalvarJogador(CreateJogadorDto jogadorDto);
    }
}
