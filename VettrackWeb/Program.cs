using Vettrack.Citas;
using Vettrack.Duenos;
using Vettrack.Mascotas;
using Vettrack.Repositorios;
using Vettrack.Veterinarios;
using VettrackWeb.ServiciosCita;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Services.AddSingleton<IRepositorio<Mascota>, RepositorioMascota>();
builder.Services.AddSingleton<IRepositorio<Dueno>, RepositorioDueno>();
builder.Services.AddSingleton<IRepositorio<Veterinario>, VeterinarioRepository>();
builder.Services.AddSingleton<IRepositorio<Cita>, CitaRepository>();

builder.Services.AddScoped<ClinicaService>();
var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
