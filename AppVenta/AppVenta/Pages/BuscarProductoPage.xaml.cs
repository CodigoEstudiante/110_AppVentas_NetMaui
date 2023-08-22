using AppVenta.ViewModels;

namespace AppVenta.Pages;

public partial class BuscarProductoPage : ContentPage
{
	public BuscarProductoPage(BuscarProductoVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}