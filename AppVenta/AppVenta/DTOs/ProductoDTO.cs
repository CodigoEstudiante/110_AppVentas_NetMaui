using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.DTOs
{
    public partial class ProductoDTO : ObservableObject
    {
        [ObservableProperty]
        public int idProducto;

        [ObservableProperty]
        public string codigo;

        [ObservableProperty]
        public string nombre;

        [ObservableProperty]
        public CategoriaDTO categoria;

        [ObservableProperty]
        public int cantidad;

        [ObservableProperty]
        public decimal precio;
    }
}
