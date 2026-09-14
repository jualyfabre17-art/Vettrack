using Vettrack.Repositorios;
using Vettrack.Mascotas;
using Vettrack.Duenos;
using Vettrack.Veterinarios;
using Vettrack.Citas;

namespace VettrackWeb.Servicios
{
    public class ClinicaService
    {
        private readonly IRepositorio<Mascota> _repoMascota;
        private readonly IRepositorio<Dueno> _repoDueno;
        private readonly IRepositorio<Veterinario> _repoVeterinario;
        private readonly IRepositorio<Cita> _repoCita;

        public ClinicaService(IRepositorio<Mascota> repoMascota, IRepositorio<Dueno> repoDueno, IRepositorio<Veterinario> repoVeterinairo, IRepositorio<Cita> repoCita) 
        {
            _repoMascota = repoMascota;
            _repoDueno = repoDueno;
            _repoVeterinario = repoVeterinairo;
            _repoCita = repoCita;
        }
    }
}
