using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
  public class MedicoCadastroModel
  {
    [Required(ErrorMessage = "Por favor, informe o nome do médico.")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "Por favor, informe o CRM do médico.")]
    public string Crm { get; set; }
    [Required(ErrorMessage = "Por favor, informe a especialização do médico.")]
    public string Especializacao { get; set; }


  }
}
