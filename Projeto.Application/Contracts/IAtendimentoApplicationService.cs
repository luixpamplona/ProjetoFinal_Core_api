using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
  public interface IAtendimentoApplicationService
  {
    void Cadastrar(AtendimentoCadastroModel model);
    void Atualizar(AtendimentoEdicaoModel model);
    void Excluir(int idAtendimento);
    List<AtendimentoConsultaModel> Consultar();
    AtendimentoConsultaModel ObterPorId(int idAtendimento);
  }
}
