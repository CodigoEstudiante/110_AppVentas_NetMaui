using AppVenta.DataAccess;
using AppVenta.DTOs;
using AppVenta.Modelos;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;


namespace AppVenta.ViewModels
{
    public partial class CategoriasVM : ObservableObject
    {
        private readonly VentaDbContext _context;

        [ObservableProperty]
        private ObservableCollection<CategoriaDTO> listaCategorias = new ObservableCollection<CategoriaDTO>();

        [ObservableProperty]
        private CategoriaDTO categoriaSeleccionada;

        [ObservableProperty]
        private string buscarCategoria = string.Empty;

        [ObservableProperty]
        private bool loadingEsVisible = false;

        [ObservableProperty]
        private bool dataEsVisible = false;

        [ObservableProperty]
        private bool btnLimpiarEsVisible = false;

        public CategoriasVM(VentaDbContext context)
        {
            _context = context;
            MainThread.BeginInvokeOnMainThread(async () => await ObtenerCategorias());
            PropertyChanged += CategoriasVM_PropertyChanged;
        }

        private void CategoriasVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BuscarCategoria))
            {
                if (BuscarCategoria != "")
                    BtnLimpiarEsVisible = true;
                else
                    BtnLimpiarEsVisible = false;
            }
        }

        public async Task ObtenerCategorias()
        {
            DataEsVisible = false;
            LoadingEsVisible = true;

            await Task.Run(async () =>
            {

                var lstCategoria = await _context.Categorias.ToListAsync();
                var lstTemp = new ObservableCollection<CategoriaDTO>();

                foreach (var item in lstCategoria)
                {
                    lstTemp.Add(new CategoriaDTO
                    {
                        IdCategoria = item.IdCategoria,
                        Nombre = item.Nombre
                    });
                }
                ListaCategorias = lstTemp;

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    DataEsVisible = true;
                    LoadingEsVisible = false;
                });
            });
        }

        [RelayCommand]
        private async Task Buscar()
        {
            DataEsVisible = false;
            LoadingEsVisible = true;

            await Task.Run(async () =>
            {
                ObservableCollection<CategoriaDTO> lista = new ObservableCollection<CategoriaDTO>();
                var lstCategorias = await _context.Categorias.Where(c => c.Nombre.ToLower().Contains(BuscarCategoria.ToLower())).ToListAsync();

                foreach (var item in lstCategorias)
                {
                    lista.Add(new CategoriaDTO
                    {
                        IdCategoria = item.IdCategoria,
                        Nombre = item.Nombre
                    });
                }
                ListaCategorias = lista;
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    DataEsVisible = true;
                    LoadingEsVisible = false;
                });
            });
        }

        [RelayCommand]
        private async Task Limpiar()
        {
            BuscarCategoria = "";
            await ObtenerCategorias();
        }

        [RelayCommand]
        private async Task Agregar()
        {

            string resultado = await Shell.Current.DisplayPromptAsync("Nueva Categoria", "Ingrese el nombre", accept: "Guardar", cancel: "Volver");
            if (!string.IsNullOrEmpty(resultado))
            {
                LoadingEsVisible = true;
                DataEsVisible = true;
                await Task.Run(async () =>
                {
                    Categoria modelo = new Categoria
                    {
                        Nombre = resultado
                    };
                    _context.Categorias.Add(modelo);
                    await _context.SaveChangesAsync();

                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        ListaCategorias.Add(new CategoriaDTO { IdCategoria = modelo.IdCategoria, Nombre = modelo.Nombre });
                        LoadingEsVisible = false;
                    });
                });
            }

        }

        [RelayCommand]
        private async Task Editar(CategoriaDTO categoria)
        {
            string resultado = await Shell.Current.DisplayPromptAsync("Editar Categoria", "Cambie el nombre", accept: "Guardar", initialValue: categoria.Nombre, cancel: "Volver");
            if (!string.IsNullOrEmpty(resultado))
            {
                LoadingEsVisible = true;
                DataEsVisible = true;
                await Task.Run(async () =>
                {
                    var encontrado = _context.Categorias.First(c => c.IdCategoria == categoria.IdCategoria);
                    encontrado.Nombre = resultado;

                    _context.Categorias.Update(encontrado);
                    await _context.SaveChangesAsync();
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        categoria.Nombre = resultado;
                        LoadingEsVisible = false;
                    });
                });
            }
        }

        [RelayCommand]
        private async Task Eliminar(CategoriaDTO categoria)
        {
            bool answer = await Shell.Current.DisplayAlert("Mensaje", "Desea eliminar la categoria?", "Si, continuar", "No, volver");
            if (answer)
            {
                LoadingEsVisible = true;
                DataEsVisible = true;
                await Task.Run(async () => {
                    var encontrado = _context.Categorias.First(c => c.IdCategoria == categoria.IdCategoria);
                    _context.Categorias.Remove(encontrado);
                    await _context.SaveChangesAsync();
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        ListaCategorias.Remove(categoria);
                        LoadingEsVisible = false;
                    });
                });
                
                
            }
        }
    }
}
