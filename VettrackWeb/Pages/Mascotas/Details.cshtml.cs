using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vettrack.Mascotas;
using Vettrack.Repositorios;

namespace VettrackWeb.Pages.Mascotas
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorio<Mascota> _repo;
        public DetailsModel(IRepositorio<Mascota> repo) => _repo = repo;

        public Mascota? Mascota { get; set; }

        public IActionResult OnGet(int id)
        {
            Mascota = _repo.ObtenerPorId(id);
            if (Mascota == null) return NotFound();
            return Page();
        }
    }
}
