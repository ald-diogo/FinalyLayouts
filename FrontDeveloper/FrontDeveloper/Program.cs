using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FrontDeveloper;
using FrontDeveloper.Layout;
using FrontDeveloper.Pages.Admin;
using FrontDeveloper.Pages.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

builder.Services.AddScoped<LayoutComponentBase, MainLayout>();

builder.Services.AddScoped<EstudanteService>();
builder.Services.AddScoped<CoordenadorAcademicoService>();
builder.Services.AddScoped<ProfessorService>();
builder.Services.AddScoped<SecretarioService>();
builder.Services.AddScoped<FuncionarioService>();
builder.Services.AddScoped<ConsultorService>();
builder.Services.AddScoped<DisciplinaService>();

await builder.Build().RunAsync();