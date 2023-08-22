using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace AppVenta.Modelos
{
    public class DetalleVenta
    {
        [Key]
        public int IdDetalleVenta { get; set; }

        public int IdProducto { get; set; }
        public virtual Producto RefProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public int IdVenta { get; set; }
        public virtual Venta RefVenta { get; set; }
    }
}
