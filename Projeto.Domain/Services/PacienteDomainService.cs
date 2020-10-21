using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
  public class PacienteDomainService
    : BaseDomainService<PacienteEntity>, IPacienteDomainService
  {
    private readonly IPacienteRepository repository;

    public PacienteDomainService(IPacienteRepository repository)
      : base(repository)
    {
      this.repository = repository;
    }
  }
}
