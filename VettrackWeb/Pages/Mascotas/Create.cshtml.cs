using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vettrack.Duenos;
using Vettrack.Mascotas;
using Vettrack.Repositorios;

namespace VettrackWeb.Pages.Mascotas
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorio<Mascota> _mascotaRepo;
        private readonly IRepositorio<Dueno> _duenoRepo;

        public CreateModel(IRepositorio<Mascota> mascotaRepo, IRepositorio<Dueno> duenoRepo)
        {
            _mascotaRepo = mascotaRepo;
            _duenoRepo = duenoRepo;
        }

        [BindProperty] public string TipoSeleccionado { get; set; } = "Perro";
        [BindProperty] public string Nombre { get; set; } = string.Empty;
        [BindProperty] public DateTime FechaNacimiento { get; set; }
        [BindProperty] public decimal PesoKg { get; set; }
        [BindProperty] public string DetalleEspecifico { get; set; } = string.Empty;
        [BindProperty] public int DuenoId { get; set; }

        public List<Dueno> Duenos { get; set; } = new();

        public void OnGet() => Duenos = _duenoRepo.ObtenerTodos();

        public IActionResult OnPost()
        {
            Duenos = _duenoRepo.ObtenerTodos();

            if (FechaNacimiento > DateTime.Today)
                ModelState.AddModelError(nameof(FechaNacimiento), "La fecha de nacimiento no puede ser futura.");

            if (!ModelState.IsValid) return Page();

            Mascota nuevaMascota = TipoSeleccionado switch
            {
                "Perro" => new Perro(Nombre, FechaNacimiento, PesoKg, DetalleEspecifico),
                "Gato" => new Gato(Nombre, FechaNacimiento, PesoKg, DetalleEspecifico == "interior"),
                "Ave" => new Ave(Nombre, FechaNacimiento, PesoKg, DetalleEspecifico),
                "Exótico" => new Exotico(Nombre, FechaNacimiento, PesoKg, DetalleEspecifico),
                _ => throw new InvalidOperationException("Tipo de mascota no reconocido")
            };

            nuevaMascota.DuenoId = DuenoId;
            _mascotaRepo.Agregar(nuevaMascota);

            return RedirectToPage("Index");
        }
    }
}
