using achei.comp.prestadorservico.domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace achei.comp.domain.prestadorservico.Entity
{
    public interface IPrestadorServicoRepository : IRepository<PrestadorServico>
    {
        Task<IEnumerable<PrestadorServico>> ListaPrestadoresAtivos(PrestadorServico entity);
    }
}
