using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vettrack.Mascotas;
using Vettrack.Repositorios;

namespace VettrackWeb.Pages.Mascotas
{
    public class MascotaIndexModel : PageModel
    {
        private readonly IRepositorio<Mascota> _repositorioMascota;

        public MascotaIndexModel(IRepositorio<Mascota> repositorioMascota)
        {
            _repositorioMascota = repositorioMascota;
        }

        [BindProperty(SupportsGet = true)]
        public int? MascotaId { get; set; }

        public IEnumerable<Mascota> mascotas { get; set; } = new List<Mascota>();
        public void OnGet()
        {
            var mascota = _repositorioMascota.ObtenerPorId(MascotaId.Value);

            if (mascota != null)
            {
                
                mascotas = new List<Mascota> { mascota };
            
        }
            else { 
            mascotas = _repositorioMascota.ObtenerTodos();
            }
        }

        [BindProperty] public string Nombre { get; private set; } = string.Empty;
        [BindProperty] public DateTime FechaNacimiento { get; private set; }
        [BindProperty] public decimal PesoKg { get; set; }
        [BindProperty] public string Raza { get; set; } = string.Empty;
        [BindProperty] public bool EsInterior { get; set; }
        [BindProperty] public string Especie { get; set; } = string.Empty;
        [BindProperty] public string TipoMascota { get; set; } = string.Empty;

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Mascota nuevaMascota = TipoMascota switch
            {
                "Perro" => new Perro(Nombre,FechaNacimiento,PesoKg,Raza)
                {
                    Nombre = this.Nombre,
                    FechaNacimiento = this.FechaNacimiento,
                    PesoKg = this.PesoKg,
                    Raza = this.Raza
                },
                "Gato" => new Gato(Nombre, FechaNacimiento, PesoKg, EsInterior)
                {
                    Nombre = this.Nombre,
                    FechaNacimiento = this.FechaNacimiento,
                    PesoKg = this.PesoKg,
                    EsInterior = this.EsInterior
                },
                "Ave" => new Ave(Nombre, FechaNacimiento, PesoKg, Especie)
                {
                    Nombre= this.Nombre,
                    FechaNacimiento = this.FechaNacimiento,
                    PesoKg = this.PesoKg,
                    Especie = this.Especie
                },
                "Exotico" => new Exotico(Nombre, FechaNacimiento, PesoKg, Especie)
                {
                    Nombre = this.Nombre,
                    FechaNacimiento = this.FechaNacimiento,
                    PesoKg = this.PesoKg,
                    Especie = this.Especie
                },
                _ => throw new InvalidOperationException("Tipo de mascota no soportado o no válido.")

            };
            _repositorioMascota.Agregar(nuevaMascota);
            return RedirectToPage("Index");

        }
    }
}
