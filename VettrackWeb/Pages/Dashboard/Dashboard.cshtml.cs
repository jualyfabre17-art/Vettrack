using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vettrack.Mascotas;
using Vettrack.Repositorios;
using VettrackWeb.ServiciosCita;

namespace VettrackWeb.Pages.Dashboard
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorio<Mascota> _mascotaRepo;
        private readonly ClinicaService _clinicaService;

        public IndexModel(IRepositorio<Mascota> mascotaRepo, ClinicaService clinicaService)
        {
            _mascotaRepo = mascotaRepo;
            _clinicaService = clinicaService;
        }

        public int TotalMascotas { get; set; }
        public Dictionary<string, int> ConteoPorTipo { get; set; } = new();
        public List<Mascota> VacunacionPendiente { get; set; } = new();

        public void OnGet()
        {
            var todas = _mascotaRepo.ObtenerTodos();
            TotalMascotas = todas.Count;

            ConteoPorTipo = new Dictionary<string, int>();
            foreach (var mascota in todas)
            {
                if (!ConteoPorTipo.ContainsKey(mascota.TipoMascota))
                    ConteoPorTipo[mascota.TipoMascota] = 0;

                ConteoPorTipo[mascota.TipoMascota]++;
            }

            VacunacionPendiente = _clinicaService.ObtenerMascotasConVacunacionPendiente();
        }
    }
}
