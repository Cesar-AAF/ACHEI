using achei.comp.orcamentos.domain.Entities;
using achei.comp.orcamentos.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
    using System.Threading.Tasks;

namespace achei.comp.orcamentos.repository.Repositories
{
    public class OrcamentoRepository : Repository<Context, Orcamento>, IOrcamentoRepository
    {
        IConfiguration _configuration;

        public OrcamentoRepository
        (
            IConfiguration configuration,
            Context context
        ) : base(context)
        {
            _configuration = configuration;
        }
    }
}
