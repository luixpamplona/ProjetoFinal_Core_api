using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
  class MedicoMapping : IEntityTypeConfiguration<MedicoEntity>
  {
    public void Configure(EntityTypeBuilder<MedicoEntity> builder)
    {
      builder.ToTable("Medico");

      builder.HasKey(m => m.IdMedico);

      builder.Property(m => m.IdMedico)
        .HasColumnName("IdMedico");

      builder.Property(m => m.Nome)
        .HasColumnName("Nome")
        .HasMaxLength(150)
        .IsRequired();

      builder.Property(m => m.Crm)
        .HasColumnName("Crm")
        .HasMaxLength(150)
        .IsRequired();

      builder.Property(m => m.Especializacao)
        .HasColumnName("Especializacao")
        .HasMaxLength(150)
        .IsRequired();




    }
  }
}
