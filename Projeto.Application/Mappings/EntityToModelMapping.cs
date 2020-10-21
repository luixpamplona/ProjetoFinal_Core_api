using AutoMapper;
using Projeto.Application.Models;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Mappings
{
  public class EntityToModelMapping : Profile
  {
    public EntityToModelMapping()
    {
      CreateMap<AtendimentoEntity, AtendimentoConsultaModel>();
      CreateMap<MedicoEntity, MedicoConsultaModel>();
      CreateMap<PacienteEntity, PacienteConsultaModel>();
    }
  }
}
