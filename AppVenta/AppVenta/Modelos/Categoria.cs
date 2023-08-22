
using System.ComponentModel.DataAnnotations;


namespace AppVenta.Modelos
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
