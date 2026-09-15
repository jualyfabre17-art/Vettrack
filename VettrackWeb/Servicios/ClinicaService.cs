using Vettrack.Repositorios;
using Vettrack.Mascotas;
using VettrackWeb.Servicios;



namespace VettrackWeb.ServiciosCita
{
        public class ClinicaServicio  { 
        
        private readonly IRepositorio<Mascota> _repoMascota;
        
        private readonly IRepositorio<Cita> _repoCita;

        public ClinicaServicio(IRepositorio<Mascota> repoMascota, IRepositorio<Cita> repoCita) 
        {
            _repoMascota = repoMascota;;
            _repoCita = repoCita;
        }

        public decimal CalcularCostoTotalCita(int citaId) 
        {
            
            var citaEncontrada = _repoCita.ObtenerPorId(citaId);

            if (citaEncontrada == null)
                throw new Exception("La cita no fue encontrada");
            
                return citaEncontrada.ServicioAsignado.CalcularCostoServicio();
        }
        
        }
    
}
