using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models;

namespace Projeto.Presentation.Controllers
{
  [EnableCors("DefaultPolicy")]
  [Route("api/[controller]")]
  [ApiController]
  public class PacienteController : ControllerBase
  {
    private readonly IPacienteApplicationService service;

    public PacienteController(IPacienteApplicationService service)
    {
      this.service = service;
    }

    [HttpPost]
    public IActionResult Post(PacienteCadastroModel model)
    {
      if (ModelState.IsValid)
      {
        try
        {
          service.Cadastrar(model);
          var result = new { message = "Médico Cadastrado com sucesso" };
          return Ok(result);
        }
        catch (Exception e)
        {
          return StatusCode(500, e.Message);
        }
      }
      else
      {
        return BadRequest();
      }


    }

    [HttpPut]

    public IActionResult Put(PacienteEdicaoModel model)
    {
      if (ModelState.IsValid)
      {
        try
        {
          service.Atualizar(model);
          var result = new { message = "Paciente atualizado com sucesso" };

          return Ok(result);
        }
        catch (Exception e)
        {

          return StatusCode(500, e.Message);
        }
      }
      else
      {
        return BadRequest();
      }

    }

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
      try
      {
        service.Excluir(id);
        var result = new { message = "Paciente Excluído com sucesso" };
        return Ok(result);
      }
      catch (Exception e)
      {

        return StatusCode(500, e.Message);
      }
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      try
      {
        return Ok(service.Consultar());
      }
      catch (Exception e)
      {

        return StatusCode(500, e.Message);
      }
    }

    [HttpGet("{id}")]

    public IActionResult GetById(int id)
    {
      try
      {
        return Ok(service.ObterPorId(id));
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }
  }
}
