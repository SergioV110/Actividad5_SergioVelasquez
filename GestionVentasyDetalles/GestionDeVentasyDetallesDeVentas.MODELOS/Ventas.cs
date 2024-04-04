using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVentasyDetallesDeVentas.MODELOS
{
    public class Ventas
    {
        public  int IdVenta {  get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }
    }
}
