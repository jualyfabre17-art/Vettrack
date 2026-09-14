using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vettrack.Repositorios;
using Vettrack.Duenos;

namespace VettrackWeb.Pages.Duenos
{
    public class DuenoIndexModel : PageModel
    {
        private readonly RepositorioDueno _repositorioDueno;
        public IEnumerable<Dueno> Duenos = new List<Dueno>();

        public DuenoIndexModel(RepositorioDueno repositorioDueno) 
        { 
            _repositorioDueno = repositorioDueno;
        }
        public void OnGet()
        {
           Duenos = _repositorioDueno.ObtenerTodos();
        }
    }
}
