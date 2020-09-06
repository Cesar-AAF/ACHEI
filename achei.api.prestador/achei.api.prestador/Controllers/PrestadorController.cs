using achei.api.prestador.Models;
using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.domain.Interfaces.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Remotion.Linq.Parsing.ExpressionVisitors.Transformation.PredefinedTransformations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace achei.api.prestador.Controllers
{
    [Route("api/prestadores")]
    [Produces("application/json")]
    [ApiController]
    public class PrestadorController : ControllerBase
    {
        private readonly IAvaliacaoService _prestadorAvaliacaoService;
        private readonly IPrestadorProfissaoService _prestadorProfissaoService;
        private readonly IPrestadorService _prestadorService;
        private readonly IPrestadorServicoService _prestadorServicoService;
        private readonly IProfissaoService _profissaoService; 
        private readonly IServicoCategoriaService _servicoCategoriaService;
        private readonly IServicoService _servicoService;
        private readonly IServicoSubCategoriaService _servicoSubCategoriaService;
         
        public PrestadorController(
            IPrestadorService prestadorService,
            IAvaliacaoService prestadorAvaliacaoService,
            IPrestadorProfissaoService prestadorProfissaoService,
            IPrestadorServicoService prestadorServicoService,
            IProfissaoService profissaoService, 
            IServicoCategoriaService servicoCategoriaService,
            IServicoService servicoService,
            IServicoSubCategoriaService servicoSubCategoriaService
            )
        {
            _prestadorService = prestadorService;
            _prestadorAvaliacaoService = prestadorAvaliacaoService;
            _prestadorProfissaoService = prestadorProfissaoService;
            _prestadorServicoService = prestadorServicoService;
            _profissaoService = profissaoService;
            _servicoSubCategoriaService = servicoSubCategoriaService;
            _servicoService = servicoService;
            _servicoCategoriaService = servicoCategoriaService;
        }

        /// <summary>
        /// Insere um prestador
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("prestador")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(PrestadorModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<PrestadorModel>> PostPrestador(Prestador model)
        {
            return Ok(await _prestadorService.Insert(model));
        }

        /// <summary>
        /// Atualiza um prestador
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("prestador/{Id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(PrestadorModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<PrestadorModel>> PutPrestador(Prestador model)
        {
            return Ok(await _prestadorService.Update(model));
        }

        /// <summary>
        /// Retorna um prestador
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("prestador/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(PrestadorModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<PrestadorModel>> GetPrestador(int id)
        {
            return Ok(await _prestadorService.GetById(new Prestador()
            {
                Id = id
            }));
        }

        /// <summary>
        /// Retorna uma lista de prestadores
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("prestadores")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<PrestadorModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PrestadorModel>>> GetPrestadores(Prestador model)
        {
            return Ok(await _prestadorService.GetList(model));
        }

        /// <summary>
        /// Inclui a profissão do prestador
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("prestador/{id}/profissao")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(PrestadorModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<PrestadorProfissaoModel>> PostPrestadorProfissao(PrestadorProfissao model)
        {
            return Ok(await _prestadorProfissaoService.Insert(model));
        }

        /// <summary>
        /// Inclui os serviços do prestador
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("prestador/{id}/servico")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(PrestadorServicoModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PrestadorServico>>> PostPrestadorServico(PrestadorServico model)
        {
            return Ok(await _prestadorServicoService.Insert(model));
        }


        /// <summary>
        /// Inclui a avaliação do prestador
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("prestador/{id}/avaliacao")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(PrestadorAvaliacao), StatusCodes.Status200OK)]
        public async Task<ActionResult<PrestadorAvaliacao>> PostPrestadorAvaliacao(PrestadorAvaliacao model)
        {
            return Ok(await _prestadorAvaliacaoService.Insert(model));
        }

        /// <summary>
        /// Retorna uma lista de serviços cadastrados
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("prestador/servicos")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<PrestadorServicoModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PrestadorServicoModel>>> GetServicos(int id)
        {
            return Ok(await _servicoService.GetList(new comp.prestador.domain.Entities.Servico()
            {
            }));
        }

        /// <summary>
        /// Retorna uma lista de profissões cadastradas
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("prestador/profissoes")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<PrestadorProfissaoModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PrestadorProfissaoModel>>> GetProfissoes()
        {
            return Ok(await _profissaoService.GetList(new comp.prestador.domain.Entities.Profissao()
            {
            }));
        }

        /// <summary>
        /// Retorna uma lista de categorias de um serviço
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("prestador/servico/{id}/categorias")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<ServicoCategoriaModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ServicoCategoriaModel>>> GetCategorias(int id)
        {
            return Ok(await _servicoCategoriaService.GetList(new comp.prestador.domain.Entities.ServicoCategoria()
            {
                Id = id
            }));
        }

        /// <summary>
        /// Retorna uma lista de sub categorias de uma categoria
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("prestador/servico/categoria/{id}/subcategorias")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<ServicoSubCategoriaModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ServicoSubCategoriaModel>>> GetSubCategorias(int id)
        {
            return Ok(await _servicoSubCategoriaService.GetList(new comp.prestador.domain.Entities.ServicoSubCategoria()
            {
                ServicoCategoriaID = id
            }));
        }
    }
}
