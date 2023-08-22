using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.Modelos
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
        public virtual Categoria RefCategoria { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public virtual ICollection<DetalleVenta> RefDetalleVenta { get; set; } = new List<DetalleVenta>();
    }
}
