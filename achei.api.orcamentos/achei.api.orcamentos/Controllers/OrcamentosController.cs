using achei.api.orcamentosservico.Models;
using achei.comp.orcamentos.domain.Entities;
using achei.comp.orcamentos.domain.Interfaces.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace achei.api.orcamentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrcamentosController : ControllerBase
    {
        private readonly IOrcamentoService _orcamentoService;

        public OrcamentosController(IOrcamentoService orcamentoService) {
               _orcamentoService = orcamentoService;
        }

        /// <summary>
        /// Retorna uma lista de orcamentos de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("orcamentos/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<OrcamentoModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<OrcamentoModel>>> Orcamentos(int id)
        { 
            return Ok(await _orcamentoService.GetList(new Orcamento() { Id = id }));
        }

        /// <summary>
        /// Retorna um orcamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("orcamento/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<Orcamento>), StatusCodes.Status200OK)]
        public async Task<ActionResult<Orcamento>> GetOrcamento(int id)
        {
            return Ok(await _orcamentoService.GetById(new comp.orcamentos.domain.Entities.Orcamento()
            {
                Id = id
            }));
        }

        /// <summary>
        /// Inclui um orçamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("orcamento")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<Orcamento>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Orcamento>>> PostOrcamento(Orcamento model)
        {
            return Ok(await _orcamentoService.Insert(model));
        }

        /// <summary>
        /// Atualiza um orçamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("orcamento")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<Orcamento>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Orcamento>>> PutOrcamento(Orcamento model)
        {
            return Ok(await _orcamentoService.Update(model));
        }
    }
}
