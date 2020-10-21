using Microsoft.EntityFrameworkCore.Storage;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
  public class UnitOfWork : IUnitOfWork
  {

    private readonly DataContext context;
    private IDbContextTransaction transaction;

    public UnitOfWork(DataContext context)
    {
      this.context = context;
    }

    public void BeginTransaction()
    {
      transaction = context.Database.BeginTransaction();
    }

    public void Commit()
    {
      transaction.Commit();
    }

    public void Rollback()
    {
      transaction.Rollback();
    }

    public IAtendimentoRepository AtendimentoRepository
    {
      get { return new AtendimentoRepository(context); }
    }

    public IMedicoRepository MedicoRepository
    {
      get { return new MedicoRepository(context); }
    }

    public IPacienteRepository PacienteRepository
    {
      get { return new PacienteRepository(context); }
    }

  }
}
