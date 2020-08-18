using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using achei.comp.domain.pedidos.Entity;

namespace achei.api.pedidos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
      
        private readonly ILogger<PedidosController> _logger;

        public PedidosController(ILogger<PedidosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return new Pedido[] { new Pedido() { } };
        }
    }
}
