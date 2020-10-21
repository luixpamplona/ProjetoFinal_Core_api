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
  public class MedicoTest
  {
    private readonly AppContext appContext;

    private readonly string endpoint;

    public MedicoTest()
    {
      appContext = new AppContext();
      endpoint = "/api/Medico";
    }

    [Fact]

    public async Task Medico_Post_ReturnsOk()
    {
      var model = new MedicoCadastroModel()
      {
        Nome = "Ilha",
        Crm = "Consulta de rotina",        
        Especializacao = "dasdsdsad"

      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                       Encoding.UTF8, "application/json");

      var response = await appContext.Client.PostAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Medico_Post_ReturnsBadRequest()
    {

      var model = new MedicoCadastroModel()
      {

        Nome = string.Empty,
        Crm = string.Empty,
        Especializacao = string.Empty        

      };
      var request = new StringContent(JsonConvert.SerializeObject(model),
                       Encoding.UTF8, "application/json");

      var response = await appContext.Client.PostAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]

    public async Task Medico_Put_ReturnsOk()
    {
      var model = new MedicoEdicaoModel()
      {
        IdMedico = Guid.NewGuid().GetHashCode(),
        Nome = "Ilha",
        Crm = "Consulta de rotina",
        Especializacao = "dasdsdsad"        
      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                      Encoding.UTF8, "application/json");

      var response = await appContext.Client.PutAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Medico_Put_ReturnsBadRequest()
    {
      var model = new MedicoEdicaoModel()
      {

        IdMedico = Guid.NewGuid().GetHashCode(),
        Nome = string.Empty,
        Crm = string.Empty,
        Especializacao = string.Empty       
      };

      var request = new StringContent(JsonConvert.SerializeObject(model),
                      Encoding.UTF8, "application/json");

      var response = await appContext.Client.PutAsync(endpoint, request);

      response.StatusCode.Should().Be(HttpStatusCode.BadRequest);

    }

    [Fact]

    public async Task Medico_Delete_ReturnsOk()
    {
      var id = Guid.NewGuid().ToString();

      var response = await appContext.Client.DeleteAsync
                     (endpoint + "/" + id);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact]

    public async Task Medico_GetAll_ReturnsOk()
    {
      var response = await appContext.Client.GetAsync(endpoint);

      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }


    [Fact]

    public async Task Medico_GetById_ReturnsOk()
    {
      var id = Guid.NewGuid().ToString();

      var response = await appContext.Client.GetAsync(endpoint + "/" + id);
      response.StatusCode.Should().Be(HttpStatusCode.OK);
    }




  }
}
