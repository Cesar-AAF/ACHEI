using achei.comp.extratos.domain.Entities;
using achei.comp.extratos.domain.Interfaces.Applications;
using achei.comp.extratos.domain.Interfaces.Repositories;
using achei.comp.extratos.repository.Repositories;
using Microsoft.Extensions.Configuration;

namespace achei.comp.extratos.application.Services
{
    public class SaldoService : Service<ISaldoRepository, Saldo>, ISaldoService
    {
        IConfiguration _configuration;
        ISaldoRepository _avaliacaoRepository;

        public SaldoService
        (
            IConfiguration configuration,
            ISaldoRepository avaliacaoRepository
        ) : base(avaliacaoRepository)
        {
            _configuration = configuration;
            _avaliacaoRepository = avaliacaoRepository;
        }
    }
}
