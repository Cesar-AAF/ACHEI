using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace achei.comp.prestador.repository.Repositories
{
    public class PrestadorProfissaoRepository : Repository<Context, PrestadorProfissao>, IPrestadorProfissaoRepository
    {
        IConfiguration _configuration;

        public PrestadorProfissaoRepository
        (
            IConfiguration configuration,
            Context context
        ) : base(context)
        {
            _configuration = configuration;
        }
    }
}
