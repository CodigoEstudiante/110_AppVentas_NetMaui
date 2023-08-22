using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.DTOs
{
    public partial class DetalleVentaDTO : ObservableObject
    {
        [ObservableProperty]
        public ProductoDTO producto;
        [ObservableProperty]
        public int cantidad;
        [ObservableProperty]
        public decimal total;
    }
}
