using System;
using final_mock.Data;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(FinalMock.Function.StartUp))]
namespace FinalMock.Function
{
  public class StartUp : FunctionsStartup
  {
    public override void Configure(IFunctionsHostBuilder builder)
    {

      string connStr = Environment.GetEnvironmentVariable("ConnectionStrings:Toons");

      builder.Services.AddDbContext<ApplicationDbContext>(
                    options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connStr));

    }
  }
}
