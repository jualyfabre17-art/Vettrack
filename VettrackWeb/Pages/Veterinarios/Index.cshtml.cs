using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vettrack.Repositorios;
using Vettrack.Veterinarios;

namespace VettrackWeb.Pages.Veterinarios
{
    public class VeterinarioIndexModel : PageModel
    {
        private readonly RepositorioVeterinario _repositorioVeterinario;
        public IEnumerable<Veterinario> Veterinarios { get; set; } = new List<Veterinario>();

        public VeterinarioIndexModel(RepositorioVeterinario repositorioVeterinario) 
        {
            _repositorioVeterinario = repositorioVeterinario;
        }
        public void OnGet()
        {
            Veterinarios = _repositorioVeterinario.ObtenerTodos();
        }
    }
}
