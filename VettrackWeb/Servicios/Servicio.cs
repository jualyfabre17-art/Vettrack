namespace VettrackWeb.Servicios
{
    public abstract class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal CostoBase { get; set; }

        public abstract decimal CalcularCostoServicio();
    }

    public class Cirugia : Servicio
    {
        public string DetalleServ { get; set; } = string.Empty;
        public bool OperacionRiesgosa { get; set; } = true;
        public decimal CostoFijoOP { get; private set; } = 1250.95m;
        

        public override decimal CalcularCostoServicio()
        {
            if (OperacionRiesgosa == true)
                return CostoBase + CostoFijoOP;
            else
                return CostoBase;

        }
    }

    public class Cita : Servicio
    {
        public string DetalleServ { get; set; } = string.Empty;
        public bool CitaEspecial { get; set; } = true;
        public decimal CostoCE { get; set; } = 950.95m;
        public Servicio ServicioAsignado { get; set; }
        public override decimal CalcularCostoServicio()
        {
            if (CitaEspecial == true)
                return CostoBase + CostoCE;
            else
                return CostoBase;


        }
    }
}
