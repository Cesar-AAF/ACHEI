using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.domain.Interfaces.Applications;
using achei.comp.prestador.domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace achei.comp.prestador.application.Services
{
    public class ServicoService : Service<IServicoRepository, Servico>, IServicoService
    {
        IConfiguration _configuration;
        IServicoRepository _servicoRepository;

        public ServicoService
        (
            IConfiguration configuration,
            IServicoRepository servicoRepository
        ) : base(servicoRepository)
        {
            _configuration = configuration;
            _servicoRepository = servicoRepository;
        }
    }
}
