using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVenta.DTOs
{
    public partial class CategoriaDTO: ObservableObject
    {
        [ObservableProperty]
        public int idCategoria;
        [ObservableProperty]
        public string nombre;
    }
}
