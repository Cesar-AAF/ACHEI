﻿using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace achei.comp.prestador.repository.Repositories
{
    public class PrestadorServicoRepository : Repository<Context, PrestadorServico>, IPrestadorServicoRepository
    {
        IConfiguration _configuration;

        public PrestadorServicoRepository
        (
            IConfiguration configuration,
            Context context
        ) : base(context)
        {
            _configuration = configuration;
        }
    }
}
