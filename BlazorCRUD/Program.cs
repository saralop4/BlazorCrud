using BlazorCRUD.Data;
using BlazorCRUD.Interfaces;
using BlazorCRUD.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IClienteServicios, ServicioCliente>();

// Acceder a la cadena de conexi�n desde el archivo de configuraci�n
var cadenaConexionSqlConfiguracion = new SqlConfiguracion(builder.Configuration.GetConnectionString("conexion"));
builder.Services.AddSingleton(cadenaConexionSqlConfiguracion);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
