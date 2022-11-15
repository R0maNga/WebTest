using Blazored.Modal;
using WebTest;
using DAL.Automapper;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

var connection = builder.Configuration["ApiBaseUrl"];

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(connection) });
builder.Services.AddAutoMapper(typeof(CupboardModelProfile), typeof(CupboardProfile));
builder.Services.AddScoped<ICupboardRepository, CupboardRepository>();
builder.Services.AddScoped<IClothesRepository, ClothesRepository>();
builder.Services.AddScoped<ICupboardModelRepository, CupboardModelRepository>();
builder.Services.AddScoped<ICupboardClothesRepository, CupboardClothesRepository>();
builder.Services.AddScoped<IProcedureRepository, ProcedureRepository>();
builder.Services.AddBlazoredModal();


await builder.Build().RunAsync();