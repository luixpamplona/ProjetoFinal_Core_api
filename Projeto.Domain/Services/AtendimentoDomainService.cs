using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
  public class AtendimentoDomainService
    : BaseDomainService<AtendimentoEntity>, IAtendimentoDomainService
  {

    private readonly IAtendimentoRepository repository;
    public AtendimentoDomainService(IAtendimentoRepository repository)
      : base(repository)
    {
      this.repository = repository;
    }
  }
}
