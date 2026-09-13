using Vettrack.Mascotas;
using Vettrack.Citas;
using Vettrack.Duenos;
using Vettrack.Repositorios;
using Vettrack.Veterinarios;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Services.AddSingleton<IRepositorio<Mascota>, RepositorioMascota>();
builder.Services.AddSingleton<IRepositorio<Dueno>, RepositorioDueno>();
builder.Services.AddSingleton<IRepositorio<Veterinario>, RepositorioVeterinario>();
builder.Services.AddSingleton<IRepositorio<Cita>, RepositorioCitas>();

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
