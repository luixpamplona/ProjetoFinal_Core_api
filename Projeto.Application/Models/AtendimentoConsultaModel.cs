using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Models
{
  public class AtendimentoConsultaModel
  {
    public int IdAtendimento { get; set; }
    public DateTime DataAtendimento { get; set; }
    public string Local { get; set; }
    public string Observacoes { get; set; }
    public PacienteConsultaModel Paciente { get; set; }
    public MedicoConsultaModel Medico{ get; set; }
  }
}
