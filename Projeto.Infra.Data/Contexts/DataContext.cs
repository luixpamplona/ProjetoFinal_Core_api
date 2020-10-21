using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contexts
{
  public class DataContext : DbContext
  {
    public  DataContext(DbContextOptions<DataContext> options)
      : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new AtendimentoMapping());
      modelBuilder.ApplyConfiguration(new MedicoMapping());
      modelBuilder.ApplyConfiguration(new PacienteMapping());

    }

    public DbSet<AtendimentoEntity> Atendimento { get; set; }
    public DbSet<MedicoEntity> Medico { get; set; }
    public DbSet<PacienteEntity> Paciente { get; set; }

  }
}
