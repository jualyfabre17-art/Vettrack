using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vettrack.Repositorios;
using Vettrack.Citas;

namespace VettrackWeb.Pages.Citas
{
    public class CitasIndexModel : PageModel
    {
        private readonly RepositorioCitas _repositorioCita;
        public IEnumerable<Cita> Citas { get; set; } = new List<Cita>();

        public CitasIndexModel(RepositorioCitas repositorioCitas) 
        {
            _repositorioCita = repositorioCitas;
        }
        public void OnGet()
        {
            Citas = _repositorioCita.ObtenerTodos();
        }
    }
}
