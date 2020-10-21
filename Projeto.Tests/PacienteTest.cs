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
  public class PacienteTest
  {
    private readonly AppContext appContext;

    private readonly string endpoint;

    public PacienteTest()
    {
      appContext = new AppContext();
      endpoint = "/api/Paciente";
    }

    [Fact]

    public async Task Paciente_Post_ReturnsOk()
    {
      var model = new PacienteCadastroModel()
      {
        Nome = "Fulano",
        Cpf = "Consulta de rotina",
        DataNascimento = new DateTime(2020, 05, 06),
        Telefone = "321312321",
        Email = "dsadsa@email.com"

      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                       Encoding.UTF8, "application/json");

      var response = await appContext.Client.PostAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Paciente_Post_ReturnsBadRequest()
    {

      var model = new PacienteCadastroModel()
      {
        Nome = string.Empty,
        Cpf = string.Empty,
        DataNascimento = new DateTime(),
        Telefone = string.Empty,
        Email = string.Empty        

      };
      var request = new StringContent(JsonConvert.SerializeObject(model),
                       Encoding.UTF8, "application/json");

      var response = await appContext.Client.PostAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]

    public async Task Paciente_Put_ReturnsOk()
    {
      var model = new PacienteEdicaoModel()
      {
        IdPaciente = Guid.NewGuid().GetHashCode(),
        Nome = "Fulano",
        Cpf = "Consulta de rotina",
        DataNascimento = new DateTime(2020, 05, 06),
        Telefone = "321312321",
        Email = "dsadsa@email.com"
      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                      Encoding.UTF8, "application/json");

      var response = await appContext.Client.PutAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Paciente_Put_ReturnsBadRequest()
    {
      var model = new PacienteEdicaoModel()
      {

        IdPaciente = Guid.NewGuid().GetHashCode(),
        Nome = string.Empty,
        Cpf = string.Empty,
        DataNascimento = new DateTime(),
        Telefone = string.Empty,
        Email = string.Empty
        
      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                      Encoding.UTF8, "application/json");

      var response = await appContext.Client.PutAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.BadRequest);

    }

    [Fact]

    public async Task Paciente_Delete_ReturnsOk()
    {
      var id = Guid.NewGuid().ToString();

      var response = await appContext.Client.DeleteAsync
                     (endpoint + "/" + id);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Paciente_GetAll_ReturnsOk()
    {
      var response = await appContext.Client.GetAsync(endpoint);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }


    [Fact]

    public async Task Paciente_GetById_ReturnsOk()
    {
      var id = Guid.NewGuid().ToString();

      var response = await appContext.Client.GetAsync(endpoint + "/" + id);
      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }




  }
}
