using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
  public class AtendimentoApplicationService : IAtendimentoApplicationService
  {
    private readonly IAtendimentoDomainService domainService;

    public AtendimentoApplicationService(IAtendimentoDomainService domainService)
    {
      this.domainService = domainService;
    }

    public void Cadastrar(AtendimentoCadastroModel model)
    {
      var atendimento = Mapper.Map<AtendimentoEntity>(model);
      domainService.Cadastrar(atendimento);
    }

    public void Atualizar(AtendimentoEdicaoModel model)
    {
      var atendimento = Mapper.Map<AtendimentoEntity>(model);
      domainService.Atualizar(atendimento);
    }

    public void Excluir(int idAtendimento)
    {
      var atendimento = domainService.ObterPorId(idAtendimento);
      domainService.Excluir(atendimento);



    }

    public List<AtendimentoConsultaModel> Consultar()
    {
      var lista = domainService.Consultar();
      return Mapper.Map<List<AtendimentoConsultaModel>>(lista);
    }



    public AtendimentoConsultaModel ObterPorId(int idAtendimento)
    {
      var atendimento = domainService.ObterPorId(idAtendimento);
      return Mapper.Map<AtendimentoConsultaModel>(atendimento);
    }
  }
}
