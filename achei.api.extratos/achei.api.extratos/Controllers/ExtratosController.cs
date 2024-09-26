using achei.api.extratos.Models;
using achei.comp.extratos.domain.Entities;
using achei.comp.extratos.domain.Interfaces.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace achei.api.extratos.Controllers
{
    [Route("api/extratos")]
    [Produces("application/json")]
    [ApiController]
    public class ExtratosController : ControllerBase
    {
        private readonly IExtratoService _extratoService;
        private readonly ISaldoService _saldoService;

        public ExtratosController(IExtratoService extratoService, ISaldoService saldoService) {
            _extratoService = extratoService;
            _saldoService = saldoService;
        }


        /// <summary>
        /// Retorna o extrato de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("extrato/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ExtratoModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<ExtratoModel>> GetExtrato(int id)
        {
            return Ok(await _extratoService.GetById(new comp.extratos.domain.Entities.Extrato()
            {
                Id = id
            }));
        }

        /// <summary>
        /// Atualiza o extrato de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("extrato/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ExtratoModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<ExtratoModel>> PutExtrato(ExtratoModel extrato)
        {
            return Ok(await _extratoService.Update(new comp.extratos.domain.Entities.Extrato()
            {
                Id = id
            }));
        }

        /// <summary>
        /// Cria o extrato de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("extrato/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ExtratoModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<ExtratoModel>> PostExtrato(ExtratoModel id)
        {
            return Ok(await _extratoService.Update(new comp.extratos.domain.Entities.Extrato()
            {
                Id = id
            }));
        }

        /// <summary>
        /// Retorna o saldo de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("saldo/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(SaldoModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<SaldoModel>> GetSaldo(int id)
        {
            return Ok(await _saldoService.GetById(new comp.extratos.domain.Entities.Saldo()
            {
                Id = id
            }));
        }

        /// <summary>
        /// Atualiza o saldo de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("saldo/{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(SaldoModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<SaldoModel>> PutSaldo(Saldo model)
        {
            return Ok(await _saldoService.Update(model));
        }
    }
}
