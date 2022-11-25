using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using QuanLyXe.Data.Manipulators;
using QuanLyXe.Domain.Interfaces;
using QuanLyXe.Providers;

internal class Program
{
    private static void Main(string[] args)
    {        
        IServiceProvider services = BuildServices();
    }

    private static IServiceProvider BuildServices()
    {
        IServiceCollection service = new ServiceCollection();
        return service.BuildServiceProvider();
    }
}
