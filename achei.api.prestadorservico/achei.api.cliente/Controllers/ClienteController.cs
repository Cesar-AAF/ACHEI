using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using achei.comp.domain.cliente.Entity;

namespace achei.api.cliente.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return  new Cliente[] { new Cliente() { } };
        }
    }
}
