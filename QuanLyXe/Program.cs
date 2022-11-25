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
        ResetDefaultDoorCountManipulator reseter = services.GetRequiredService<ResetDefaultDoorCountManipulator>();
        DoubleDoorCountManipulator doubler = services.GetRequiredService<DoubleDoorCountManipulator>();

        var vehicles = reader.GetAll();

        if (reader is DemoDataReader)
        {
            writer.Write(datas: vehicles, message: "ORIGIN");
        }

        halfer.Manipulate(vehicles);
        writer.Write(datas: vehicles, message: "DEVIDED BY 2 - FIRST");
        
        halfer.Manipulate(vehicles);
        writer.Write(datas: vehicles, message: "DEVIDED BY 2 - SECOND");

        reseter.Manipulate(vehicles);
        writer.Write(datas: vehicles, message: "RESETED");

        doubler.Manipulate(vehicles);
        writer.Write(datas: vehicles, message:"DOUBLED");

        //Console.ReadLine();
    }

    private static IServiceProvider BuildServices()
    {
        IServiceCollection service = new ServiceCollection();

        service.AddSingleton<IAppConfig>(new AppConfig()
        {
            DataFileName = "data.txt",
            JsonSerializerSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
            }
        });

        service.AddScoped<HalfDoorCountManipulator>();
        service.AddScoped<DoubleDoorCountManipulator>();
        service.AddScoped<ResetDefaultDoorCountManipulator>();
        service.AddScoped<IDataReader, DemoDataReader>();
        service.AddScoped<IDataWriter, ConsoleWriter>();

        return service.BuildServiceProvider();
    }
}
