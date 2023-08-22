using AppVenta.ViewModels;

namespace AppVenta.Pages;

public partial class CategoriasPage : ContentPage
{
    public CategoriasPage(CategoriasVM viewmodel)
	{
		InitializeComponent();
        BindingContext = viewmodel;
    }

}