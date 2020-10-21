using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
  public class AtendimentoEdicaoModel
  {
    [Required(ErrorMessage = "Por favor, informe o atendimento.")]
    public int IdAtendimento { get; set; }

    [Required(ErrorMessage = "Por favor, informe a data do atendimento.")]
    public DateTime DataAtendimento { get; set; }

    [Required(ErrorMessage = "Por favor, informe o local do atendimento.")]

    public string Local { get; set; }

    [Required(ErrorMessage = "Por favor, informe a observação do atendimento.")]

    public string Observacoes { get; set; }

    [Required(ErrorMessage = "Por favor, informe o médico do atendimento.")]

    public int IdMedico { get; set; }

    [Required(ErrorMessage = "Por favor, informe o paciente do atendimento.")]

    public int IdPaciente { get; set; }

    
  }
}
