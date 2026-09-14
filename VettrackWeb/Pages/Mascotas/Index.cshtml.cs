using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vettrack.Mascotas;
using Vettrack.Repositorios;

namespace VettrackWeb.Pages.Mascotas
{
    public class MascotaIndexModel : PageModel
    {
        private readonly IRepositorio<Mascota> _repositorioMascota;
        public IEnumerable<Mascota> Mascotas = new List<Mascota>();
        public MascotaIndexModel(IRepositorio<Mascota> repositorioMascota)
        {
            _repositorioMascota = repositorioMascota;
        }

        public void OnGet()
        {
            Mascotas = _repositorioMascota.ObtenerTodos();
        }
    }
}
