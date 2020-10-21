using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Projeto.Tests
{
  public class AppContext
  {
    public HttpClient Client { get; set; }

    private readonly TestServer testServer;

    public AppContext()
    {
      var configuration = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json")
          .Build();
          
      testServer = new TestServer(new WebHostBuilder()
                            .UseStartup<Presentation.Startup>());

      Client = testServer.CreateClient();
    }
  }
}
