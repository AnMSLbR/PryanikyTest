using PryanikyTest.Interfaces;
using PryanikyTest.Models;
using System.Text.Encodings.Web;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IProducts, Products>();
builder.Services.AddSingleton<IOrders, Orders>();
builder.Services.AddMvc().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.WriteIndented = true;
    options.JsonSerializerOptions.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
});
var app = builder.Build();

app.MapControllers();
app.Run();
