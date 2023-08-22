using AppVenta.DataAccess;
using AppVenta.DTOs;
using AppVenta.Modelos;
using AppVenta.Utilidades;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;


namespace AppVenta.ViewModels
{
    public partial class BuscarProductoVM : ObservableObject
    {
        private readonly VentaDbContext _context;
        public BuscarProductoVM(VentaDbContext context)
        {
            _context = context;
        }

        [ObservableProperty]
        ObservableCollection<ProductoDTO> listaProducto = new ObservableCollection<ProductoDTO>();

        [ObservableProperty]
        private ProductoDTO productoSeleccionado;

        [ObservableProperty]
        private bool loadingCategoriaEsVisible = false;
        [ObservableProperty]
        private bool loadingEsVisible = false;
        [ObservableProperty]
        private string busqueda;

        [RelayCommand]
        private async Task EjecutarBusqueda()
        {
            LoadingEsVisible = true;

            await Task.Run(async () =>
            {
                ObservableCollection<ProductoDTO> encontrados = new ObservableCollection<ProductoDTO>();

                List<Producto> bdListCategorias = new List<Producto>();
                if(Busqueda != null)
                    if(Busqueda.Length > 0)
                        bdListCategorias = await _context.Productos.Include(c => c.RefCategoria)
                        .Where(p => string.Concat(p.Nombre.ToLower(),p.RefCategoria.Nombre.ToLower()).Contains(Busqueda.ToLower())).ToListAsync();
                    else
                        bdListCategorias = await _context.Productos.Include(c => c.RefCategoria).ToListAsync();

                foreach (var item in bdListCategorias)
                {
                    encontrados.Add(new ProductoDTO
                    {
                        IdProducto = item.IdProducto,
                        Codigo = item.Codigo,
                        Nombre = item.Nombre,
                        Categoria = new CategoriaDTO { IdCategoria = item.RefCategoria.IdCategoria, Nombre = item.RefCategoria.Nombre },
                        Cantidad = item.Cantidad,
                        Precio = item.Precio
                    });
                }

                ListaProducto = encontrados;
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    LoadingEsVisible = false;
                });
            });

        }

        [RelayCommand]
        private async Task ChangedProductoSeleccionado()
        {
            await Task.Delay(100);

            if (ProductoSeleccionado != null)
            {
                WeakReferenceMessenger.Default.Send(new ProductoVentaMessage(ProductoSeleccionado));
                await Task.Run(() =>
                {
                    ProductoSeleccionado = null;
                });
            }

        }

        [RelayCommand]
        private async Task Volver()
        {
            await Shell.Current.Navigation.PopModalAsync();
        }


    }
}
