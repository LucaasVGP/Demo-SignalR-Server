using DemoSignalR.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();


var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
	endpoints.MapHub<SignalRHub>("/signalrhub");
});
app.Run();
