using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.domain.Interfaces.Applications;
using achei.comp.prestador.domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace achei.comp.prestador.application.Services
{
    public class AvaliacaoService : Service<IAvaliacaoRepository, PrestadorAvaliacao>, IAvaliacaoService
    {
        IConfiguration _configuration;
        IAvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoService
        (
            IConfiguration configuration,
            IAvaliacaoRepository avaliacaoRepository
        ) : base(avaliacaoRepository)
        {
            _configuration = configuration;
            _avaliacaoRepository = avaliacaoRepository;
        }
    }
}
