using AppVenta.Pages;

namespace AppVenta
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void CerrarSesion_Clicked(object sender, EventArgs e)
        {
            bool answer = await Shell.Current.DisplayAlert("Mensaje", "Desea salir?", "Si, continuar", "No, volver");
            if (answer)
            {
                Preferences.Set("logueado", string.Empty);
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}