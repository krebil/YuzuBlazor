using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorExample.Components.Components;
using BlazorExample.Components.Components.Dashboards;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.RootComponents.RegisterAsCustomElement<ShowMe>("show-me");
builder.RootComponents.RegisterAsCustomElement<YuzuPreview>("preview-yuzu");
await builder.Build().RunAsync();