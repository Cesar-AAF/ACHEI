using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.domain.Interfaces.Applications;
using achei.comp.prestador.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace achei.comp.prestador.application.Services
{
    public class PrestadorServicoService : Service<IPrestadorServicoRepository, PrestadorServico>, IPrestadorServicoService  
    {
        IConfiguration _configuration;
        IPrestadorServicoRepository _prestadorServicoRepository;

        public PrestadorServicoService
        (
            IConfiguration configuration,
            IPrestadorServicoRepository prestadorServicoRepository
        ) : base(prestadorServicoRepository)
        {
            _configuration = configuration;
            _prestadorServicoRepository = prestadorServicoRepository;
        }
    }
}
