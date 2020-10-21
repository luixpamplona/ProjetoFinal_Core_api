using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
  public class AtendimentoMapping : IEntityTypeConfiguration<AtendimentoEntity>
  {
    public void Configure(EntityTypeBuilder<AtendimentoEntity> builder)
    {
      builder.ToTable("Atendimento");

      builder.HasKey(a => a.IdAtendimento);

      builder.Property(a => a.IdAtendimento)
        .HasColumnName("IdAtendimento");

      builder.Property(a => a.DataAtendimento)
        .HasColumnName("DataAtendimento")
        .HasColumnType("date")
        .IsRequired();

      builder.Property(a => a.Local)
        .HasColumnName("Local")
        .HasMaxLength(100)
        .IsRequired();

      builder.Property(a => a.Observacoes)
        .HasColumnName("Observacoes")
        .HasMaxLength(100)
        .IsRequired();

      builder.Property(a => a.IdMedico)
        .HasColumnName("IdMedico")
        .IsRequired();

      builder.Property(a => a.IdPaciente)
        .HasColumnName("IdPaciente")
        .IsRequired();


      #region Relacionamentos

      builder.HasOne(a => a.Paciente) //Atendimento tem um Paciente
        .WithMany(p => p.Atendimentos)
        .HasForeignKey(a => a.IdPaciente);

      builder.HasOne(a => a.Medico) //Atendimento tem um Paciente
        .WithMany(m => m.Atendimentos)
        .HasForeignKey(a => a.IdMedico);

      #endregion


    }
  }
}
