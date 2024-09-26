using achei.comp.extratos.domain.Entities;
using achei.comp.extratos.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
    using System.Threading.Tasks;

namespace achei.comp.extratos.repository.Repositories
{
    public class ExtratoRepository : Repository<Context, Extrato>, IExtratoRepository
    {
        IConfiguration _configuration;

        public ExtratoRepository
        (
            IConfiguration configuration,
            Context context
        ) : base(context)
        {
            _configuration = configuration;
        }
    }
}
