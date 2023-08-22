using AppVenta.ViewModels;

namespace AppVenta.Pages;

public partial class HistoriaVentaPage : ContentPage
{
	public HistoriaVentaPage(HistorialVentaVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}