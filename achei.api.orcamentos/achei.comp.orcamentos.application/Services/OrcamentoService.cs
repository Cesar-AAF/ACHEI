using achei.comp.orcamentos.domain.Entities;
using achei.comp.orcamentos.domain.Interfaces.Applications;
using achei.comp.orcamentos.domain.Interfaces.Repositories;
using achei.comp.orcamentos.repository.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace achei.comp.orcamentos.application.Services {
    public class OrcamentoService : Service<IOrcamentoRepository, Orcamento>, IOrcamentoService {

        IConfiguration _configuration;
        IOrcamentoRepository _orcamentoRepository;

        public OrcamentoService(IConfiguration configuration, IOrcamentoRepository orcamentoRepository) : base(orcamentoRepository) {
            _configuration = configuration;
            _orcamentoRepository = orcamentoRepository;
        } 
    }
}
