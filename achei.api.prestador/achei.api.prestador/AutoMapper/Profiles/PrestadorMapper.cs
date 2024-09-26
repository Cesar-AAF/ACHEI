using achei.api.prestador.Models;
using achei.comp.prestador.domain.Entities;
using AutoMapper;
using System;

namespace achei.api.prestador.AutoMapper.Profiles
{
	public class PrestadorMapper : Profile
	{
		public PrestadorMapper()
		{
			CreateMap<Prestador, PrestadorModel>();
			CreateMap<PrestadorAvaliacao, PrestadorAvaliacaoModel>();
			CreateMap<PrestadorProfissao, PrestadorProfissaoModel>();
			CreateMap<PrestadorServico, PrestadorServicoModel>();
		}
	}
}
