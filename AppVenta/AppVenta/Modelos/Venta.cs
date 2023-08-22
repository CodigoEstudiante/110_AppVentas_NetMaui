using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.Modelos
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public string Cliente { get; set; }
        public string NumeroVenta { get; set; }
        public decimal Total { get; set; }
        public decimal PagoCon { get; set; }
        public decimal Cambio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public virtual ICollection<DetalleVenta> RefDetalleVenta { get; set; } = new List<DetalleVenta>();
    }
}
