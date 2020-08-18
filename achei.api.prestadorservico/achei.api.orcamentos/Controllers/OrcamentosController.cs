using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using achei.comp.domain.orcamentos.Entity;

namespace achei.api.orcamentos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrcamentosController : ControllerBase
    {
       
        private readonly ILogger<OrcamentosController> _logger;

        public OrcamentosController(ILogger<OrcamentosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Orcamento> Get()
        {
            return new Orcamento[] { new Orcamento() { } };
        }
    }
}
