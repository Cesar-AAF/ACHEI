using achei.comp.extratos.domain.Entities;
using achei.comp.extratos.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
    using System.Threading.Tasks;

namespace achei.comp.extratos.repository.Repositories
{
    public class SaldoRepository : Repository<Context, Saldo>, ISaldoRepository {
        IConfiguration _configuration;

        public SaldoRepository
        (
            IConfiguration configuration,
            Context context
        ) : base(context)
        {
            _configuration = configuration;
        }

        public Task<Extrato> Delete(Extrato entity) {
            throw new System.NotImplementedException();
        }

        public Task<Extrato> GetById(Extrato entity) {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Extrato>> GetList(Extrato entity) {
            throw new System.NotImplementedException();
        }

        public Task<Extrato> Insert(Extrato entity) {
            throw new System.NotImplementedException();
        }

        public Task<Extrato> Update(Extrato entity) {
            throw new System.NotImplementedException();
        }
    }
}
