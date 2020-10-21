using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
  public interface IMedicoApplicationService
  {
    void Cadastrar(MedicoCadastroModel model);
    void Atualizar(MedicoEdicaoModel model);
    void Excluir(int idMedico);
    List<MedicoConsultaModel> Consultar();
    MedicoConsultaModel ObterPorId(int idMedico);
  }
}
