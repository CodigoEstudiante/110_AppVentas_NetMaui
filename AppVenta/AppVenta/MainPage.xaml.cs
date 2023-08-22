using AppVenta.ViewModels;

namespace AppVenta
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainVM vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        
    }
}