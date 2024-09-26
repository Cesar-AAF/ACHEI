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
    public class PrestadorProfissaoService : Service<IPrestadorProfissaoRepository, PrestadorProfissao>, IPrestadorProfissaoService
    {
        IConfiguration _configuration;
        IPrestadorProfissaoRepository _prestadorProfissaoRepository;

        public PrestadorProfissaoService
        (
            IConfiguration configuration,
            IPrestadorProfissaoRepository prestadorProfissaoRepository
        ) : base(prestadorProfissaoRepository)
        {
            _configuration = configuration;
            _prestadorProfissaoRepository = prestadorProfissaoRepository;
        }
    }
}
