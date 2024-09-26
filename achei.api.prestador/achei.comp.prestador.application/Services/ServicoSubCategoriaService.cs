using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.domain.Interfaces.Applications;
using achei.comp.prestador.domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace achei.comp.prestador.application.Services
{
    public class ServicoSubCategoriaService : Service<IServicoSubCategoriaRepository, ServicoSubCategoria>, IServicoSubCategoriaService
    {
        IConfiguration _configuration;
        IServicoSubCategoriaRepository _servicoSubCategoriaRepository;

        public ServicoSubCategoriaService
        (
            IConfiguration configuration,
            IServicoSubCategoriaRepository servicoSubCategoriaRepository
        ) : base(servicoSubCategoriaRepository)
        {
            _configuration = configuration;
            _servicoSubCategoriaRepository = servicoSubCategoriaRepository;
        }
    }
}
