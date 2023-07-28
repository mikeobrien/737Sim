using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SimConfigServer;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(builder =>
    {
        builder.UseWebRoot(AppContext.BaseDirectory);
        builder.UseContentRoot(Path.Combine(AppContext.BaseDirectory, "wwwroot"));
        builder.UseStartup<Startup>();
    })
    .UseWindowsService();

builder.ConfigureServices(x =>
{
    x.AddWindowsService(options =>
    {
        options.ServiceName = "SimConfigServer";
    });

    //x.AddHostedService<WindowsBackgroundService>();
});


builder
    .Build()
    .Run();