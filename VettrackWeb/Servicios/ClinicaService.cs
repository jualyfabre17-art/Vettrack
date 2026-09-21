using Microsoft.AspNetCore.DataProtection.Repositories;
using Vettrack.Citas;
using Vettrack.Interfaces;
using Vettrack.Mascotas;
using Vettrack.Repositorios;



namespace VettrackWeb.ServiciosCita
{
     public class ClinicaService  {
     private readonly IRepositorio<Cita> _citaRepository;
     private readonly IRepositorio<Mascota> _mascotaRepository;

        public ClinicaService(IRepositorio<Cita> citaRepository, IRepositorio<Mascota> mascotarepository)
        {
            _citaRepository = citaRepository;
            _mascotaRepository = mascotarepository;
        }
        
        public decimal CostoTotalCita(int mascotaId)
        {
            var mascota = _mascotaRepository.ObtenerPorId(mascotaId);

            if(mascota == null)
            {
                throw new Exception("Cita no encontrada");
            }
            else
            {
                return mascota.CalcularCostoConsultaBase();
            }
        }

        public bool Disponibilidad(int veterinarioId, DateTime FechaPropuesta, TimeSpan MargenMinimo)
        {
            var veterinarioDispo = _citaRepository.ObtenerPorId(veterinarioId);

            foreach(var cita in _citaRepository.ObtenerTodos())
            {
                TimeSpan intervaloCita = (cita.FechaHora - FechaPropuesta).Duration();

                if(intervaloCita < MargenMinimo)
                {
                    return false;
                }
            }
            return true;
        }
        public List<Mascota> ObtenerMascotasConVacunacionPendiente()
        {
            var pendientes = new List<Mascota>();

            foreach (var mascota in _mascotaRepository.ObtenerTodos())
            {
                if (mascota is IVacunable vacunable && !vacunable.EstaVacunacionAlDia())
                {
                    pendientes.Add(mascota);
                }
            }
            return pendientes;
        }

    }
    
}
