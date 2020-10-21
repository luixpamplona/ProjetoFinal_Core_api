using FluentAssertions;
using Newtonsoft.Json;
using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Projeto.Tests
{
  public class AtendimentoTest
  {
    private readonly AppContext appContext;

    private readonly string endpoint;

    public AtendimentoTest()
    {
      appContext = new AppContext();
      endpoint = "/api/Atendimento";
    }

    [Fact]

    public async Task Atendimento_Post_ReturnsOk()
    {
      var model = new AtendimentoCadastroModel()
      {
        DataAtendimento = new DateTime(2020, 05, 06),
        Local = "Ilha",
        Observacoes = "Consulta de rotina",
        IdMedico = 1,
        IdPaciente = 1

      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                       Encoding.UTF8, "application/json");

      var response = await appContext.Client.PostAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Atendimento_Post_ReturnsBadRequest()
    {

      var model = new AtendimentoCadastroModel()
      {

        DataAtendimento = new DateTime(),
        Local = string.Empty,
        Observacoes = string.Empty,
        IdMedico = 1,
        IdPaciente = 1

      };
      var request = new StringContent(JsonConvert.SerializeObject(model),
                       Encoding.UTF8, "application/json");

      var response = await appContext.Client.PostAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]

    public async Task Atendimento_Put_ReturnsOk()
    {
      var model = new AtendimentoEdicaoModel()
      {
        IdAtendimento = Guid.NewGuid().GetHashCode(),
        DataAtendimento = new DateTime(2020, 05, 06),
        Local = "Ilha",
        Observacoes = "Consulta de rotina teste",
        IdMedico = 1,
        IdPaciente = 1
      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                      Encoding.UTF8, "application/json");

      var response = await appContext.Client.PutAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Atendimento_Put_ReturnsBadRequest()
    {
      var model = new AtendimentoEdicaoModel()
      {
        IdAtendimento = Guid.NewGuid().GetHashCode(),
        DataAtendimento = new DateTime(),
        Local = string.Empty,
        Observacoes = string.Empty,
        IdMedico = 1,
        IdPaciente = 1
      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                      Encoding.UTF8, "application/json");

      var response = await appContext.Client.PutAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.BadRequest);

    }

    [Fact]

    public async Task Atendimento_Delete_ReturnsOk()
    {
      var id = Guid.NewGuid().ToString();

      var response = await appContext.Client.DeleteAsync
                     (endpoint + "/" + id);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Atendimento_GetAll_ReturnsOk()
    {
      var response = await appContext.Client.GetAsync(endpoint);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }


      [Fact]

    public async Task Atendimento_GetById_ReturnsOk()
    {
      var id = Guid.NewGuid().ToString();

      var response = await appContext.Client.GetAsync(endpoint + "/" + id);
      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }




  }
}
