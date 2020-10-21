using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
  public class AtendimentoEntity
  {
    public int IdAtendimento { get; set; }
    public DateTime DataAtendimento { get; set; }
    public string Local { get; set; }
    public string Observacoes { get; set; }
    public int IdMedico { get; set; }
    public int IdPaciente { get; set; }

    #region Relacionamentos

    public PacienteEntity Paciente { get; set; }
    public MedicoEntity Medico { get; set; }
    #endregion
  }
}
