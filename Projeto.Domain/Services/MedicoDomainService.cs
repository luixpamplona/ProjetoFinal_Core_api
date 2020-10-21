using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
  public class MedicoDomainService
    : BaseDomainService<MedicoEntity>, IMedicoDomainService
  {
    private readonly IMedicoRepository repository;

    public MedicoDomainService(IMedicoRepository repository)
      : base(repository)
    {
      this.repository = repository;
    }
  }
}
