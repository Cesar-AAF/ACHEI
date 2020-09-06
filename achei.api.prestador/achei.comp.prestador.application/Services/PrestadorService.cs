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
    public class PrestadorService : Service<IPrestadorRepository, Prestador>, IPrestadorService
    {
        IConfiguration _configuration;
        IPrestadorRepository _prestadorRepository;

        public PrestadorService
        (
            IConfiguration configuration,
            IPrestadorRepository prestadorRepository
        ) : base(prestadorRepository)
        {
            _configuration = configuration;
            _prestadorRepository = prestadorRepository;
        }
    }
}
