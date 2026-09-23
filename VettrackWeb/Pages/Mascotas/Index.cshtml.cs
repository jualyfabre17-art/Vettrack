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
    }
}
