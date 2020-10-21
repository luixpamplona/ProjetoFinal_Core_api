using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
  public class PacienteEntity
  {
    public int IdPaciente { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    #region Relacionamentos

    public List<AtendimentoEntity> Atendimentos { get; set; }
    #endregion
  }
}
