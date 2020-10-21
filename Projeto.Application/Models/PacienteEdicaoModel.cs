using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
  public class PacienteEdicaoModel
  {
    [Required(ErrorMessage = "Por favor, informe o paciente.")]
    public int IdPaciente { get; set; }
    [Required(ErrorMessage = "Por favor, informe o nome do paciente.")]

    public string Nome { get; set; }
    [Required(ErrorMessage = "Por favor, informe o CPF do paciente.")]
    public string Cpf { get; set; }
    [Required(ErrorMessage = "Por favor, informe a data de nascimento do paciente.")]
    public DateTime DataNascimento { get; set; }
    [Required(ErrorMessage = "Por favor, informe o Telefone do paciente.")]
    public string Telefone { get; set; }
    [Required(ErrorMessage = "Por favor, informe o E-mail do paciente.")]
    public string Email { get; set; }
  }
}
