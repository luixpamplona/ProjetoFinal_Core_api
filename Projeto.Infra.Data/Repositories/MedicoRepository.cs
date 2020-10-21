using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
  public class MedicoRepository
    : BaseRepository<MedicoEntity>, IMedicoRepository
  {
    private readonly DataContext context;
    public MedicoRepository(DataContext context)
      : base(context)
    {
      this.context = context;
    }
  }
}
