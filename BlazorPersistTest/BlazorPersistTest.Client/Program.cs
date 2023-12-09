using BlazorPersistTest.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<IRenderingMode, ClientRenderingMode>();

await builder.Build().RunAsync();
