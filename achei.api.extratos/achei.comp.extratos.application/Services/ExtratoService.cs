using achei.comp.extratos.domain.Entities;
using achei.comp.extratos.domain.Interfaces.Applications;
using achei.comp.extratos.domain.Interfaces.Repositories;
using achei.comp.extratos.repository.Repositories;
using Microsoft.Extensions.Configuration;

namespace achei.comp.extratos.application.Services
{
    public class ExtratoService : Service<IExtratoRepository, Extrato>, IExtratoService
    {
        IConfiguration _configuration;
        IExtratoRepository _avaliacaoRepository;

        public ExtratoService
        (
            IConfiguration configuration,
            IExtratoRepository avaliacaoRepository
        ) : base(avaliacaoRepository)
        {
            _configuration = configuration;
            _avaliacaoRepository = avaliacaoRepository;
        }
    }
}
