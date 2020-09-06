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
    public class ServicoCategoriaService : Service<IServicoCategoriaRepository, ServicoCategoria>, IServicoCategoriaService
    {
        IConfiguration _configuration;
        IServicoCategoriaRepository _servicoCategoriaRepository;

        public ServicoCategoriaService
        (
            IConfiguration configuration,
            IServicoCategoriaRepository servicoCategoriaRepository
        ) : base(servicoCategoriaRepository)
        {
            _configuration = configuration;
            _servicoCategoriaRepository = servicoCategoriaRepository;
        }
    }
}
