using AppVenta.ViewModels;

namespace AppVenta.Pages;

public partial class InventarioPage : ContentPage
{
	public InventarioPage(InventarioVM viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}