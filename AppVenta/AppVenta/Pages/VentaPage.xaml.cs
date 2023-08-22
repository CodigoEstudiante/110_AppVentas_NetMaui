using AppVenta.ViewModels;

namespace AppVenta.Pages;

public partial class VentaPage : ContentPage
{
	public VentaPage(VentaVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}