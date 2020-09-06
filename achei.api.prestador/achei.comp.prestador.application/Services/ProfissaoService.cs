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
    public class ProfissaoService : Service<IProfissaoRepository, Profissao>, IProfissaoService
    {
        IConfiguration _configuration;
        IProfissaoRepository _profissaoRepository;

        public ProfissaoService
        (
            IConfiguration configuration,
            IProfissaoRepository profissaoRepository
        ) : base(profissaoRepository)
        {
            _configuration = configuration;
            _profissaoRepository = profissaoRepository;
        }
    }
}
