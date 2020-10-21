using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
  public class AtendimentoRepository
    : BaseRepository<AtendimentoEntity>, IAtendimentoRepository
  {

    private readonly DataContext context;
    public AtendimentoRepository(DataContext context)
      : base(context)
    {
      this.context = context;
    }

    public override List<AtendimentoEntity> GetAll()
    {
      return context.Atendimento
              .Include(a => a.Medico)
              .Include(a => a.Paciente)
              .ToList();
    }

    public override List<AtendimentoEntity> GetAll(Func<AtendimentoEntity, bool> where)
    {
      return context.Atendimento
              .Include(a => a.Medico)
              .Include(a => a.Paciente)
              .ToList();
    }

    public override AtendimentoEntity Get(Func<AtendimentoEntity, bool> where)
    {
      return context.Atendimento
              .Include(a => a.Medico)
              .Include(a => a.Paciente)
              .FirstOrDefault(where);
    }

    public override AtendimentoEntity GetById(int id)
    {
      return context.Atendimento
              .Include(a => a.Medico)
              .Include(a => a.Paciente)
              .FirstOrDefault(a => a.IdAtendimento == id);
    }

  }
}
