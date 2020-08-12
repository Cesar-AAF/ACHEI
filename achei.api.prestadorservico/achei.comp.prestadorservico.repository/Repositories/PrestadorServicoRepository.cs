using achei.comp.domain.prestadorservico.Entity;
using achei.comp.prestadorservico.domain.Entity;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace achei.comp.prestadorservico.repository.Repositories
{
    public class PrestadorServicoRepository : Repository<Context, PrestadorServico>, IPrestadorServicoRepository
    {
        IConfiguration _configuration;

        public PrestadorServicoRepository
        (
            IConfiguration configuration,
            Context context
        ) : base(context)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<PrestadorServico>> ListaPrestadoresAtivos(PrestadorServico entity)
        {
            var obj = await (from ps in _context.PrestadorServico
                            select ps).SingleOrDefaultAsync();

            return obj;
        }
    }
}
