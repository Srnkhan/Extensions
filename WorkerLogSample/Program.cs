using LogExtension;
using Serilog;
using WorkerLogSample;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .MongoUseSerilog()
    .Build();

host.Run();
