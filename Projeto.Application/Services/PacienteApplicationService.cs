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
  public class PacienteApplicationService : IPacienteApplicationService
  {
    private readonly IPacienteDomainService domainService;

    public PacienteApplicationService(IPacienteDomainService domainService)
    {
      this.domainService = domainService;
    }

    public void Cadastrar(PacienteCadastroModel model)
    {
      var paciente = Mapper.Map<PacienteEntity>(model);
      domainService.Cadastrar(paciente);
    }

    public void Atualizar(PacienteEdicaoModel model)
    {
      var paciente = Mapper.Map<PacienteEntity>(model);
      domainService.Atualizar(paciente);
    }

    public void Excluir(int idPaciente)
    {
      var paciente = domainService.ObterPorId(idPaciente);
      domainService.Excluir(paciente);
    }



    public List<PacienteConsultaModel> Consultar()
    {
      var lista = domainService.Consultar();
      return Mapper.Map<List<PacienteConsultaModel>>(lista);
    }



    public PacienteConsultaModel ObterPorId(int idPaciente)
    {
      var paciente = domainService.ObterPorId(idPaciente);
      return Mapper.Map<PacienteConsultaModel>(paciente);
    }
  }
}
