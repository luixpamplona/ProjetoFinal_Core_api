using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
  public class MedicoEntity
  {
    public int IdMedico { get; set; }
    public string Nome { get; set; }
    public string Crm { get; set; }
    public string Especializacao { get; set; }

    public List<AtendimentoEntity> Atendimentos { get; set; }
  }
}
