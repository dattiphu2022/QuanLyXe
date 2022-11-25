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

        IDataReader reader = services.GetRequiredService<IDataReader>();
        IDataWriter writer = services.GetRequiredService<IDataWriter>();
        HalfDoorCountManipulator halfer = services.GetRequiredService<HalfDoorCountManipulator>();

        var vehicles = reader.GetAll();


        halfer.Manipulate(vehicles);
        writer.Write(datas: vehicles, message: "DEVIDED BY 2 - FIRST");
        
    }

    private static IServiceProvider BuildServices()
    {
        IServiceCollection service = new ServiceCollection();
        return service.BuildServiceProvider();
    }
}
