using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIntegrador.Entidades
{
    public class PagoSocio
    {
        public DateTime FechaPago { get; set; } = DateTime.Now;
        public float MontoPago { get; set; }
        public string MetodoPago { get; set; }
        public DateTime FechaVencimiento { get; set; } = DateTime.Now.AddMonths(1);
        public int IdSocio { get; set; }
        public PagoSocio(float montoPago, string metodoPago, int idSocio)
        {
            MontoPago = montoPago;
            MetodoPago = metodoPago;
            IdSocio = idSocio;
        }
    }
}
