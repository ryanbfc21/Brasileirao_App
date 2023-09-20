using AutoMapper;
using Brasileirao_App.Data.Dtos;
using Brasileirao_App.Models;

namespace Brasileirao_App.Profiles
{
    public class JogadorProfile : Profile
    {
        public JogadorProfile()
        {
            CreateMap<CreateJogadorDto, Jogador>();
        }
    }
}
