using Microsoft.Extensions.DependencyInjection;
using AW.MathHelpers.Interfaces;

namespace AW.MathHelpers.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static void AddMathHelpers(this IServiceCollection services)
    {
      services.AddScoped<IRandomNumberService, Services.RandomNumberService>();
    }
  }
}
