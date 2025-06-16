using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIntegrador.Entidades
{
    public class PagoNoSocio
    {
        public string Actividad { get; set; }
        public DateTime FechaPago { get; set; } = DateTime.Now;
        public float MontoPago { get; set; }
        public string MetodoPago { get; set; }
        public int IdNoSocio { get; set; }
        public PagoNoSocio(float montoPago, string metodoPago, int idNoSocio, string actividad)
        {
            MontoPago = montoPago;
            MetodoPago = metodoPago;
            IdNoSocio = idNoSocio;
            Actividad = actividad;
        }
    }
}
