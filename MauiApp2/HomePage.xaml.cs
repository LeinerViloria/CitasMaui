namespace MauiApp2;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }
    private void AgendarCita(object sender, EventArgs e)
    {
        // Navegar a la p�gina de agendar cita
        Navigation.PushAsync(new AgendarCitas());
    }

    private void VerCitas(object sender, EventArgs e)
    {
        // Navegar a la p�gina de ver citas
        Navigation.PushAsync(new VerCitasPage());
    }

    private void VerCatalogo(object sender, EventArgs e)
    {
        // Crear una nueva cita
        // ...
        Navigation.PushAsync(new VerCatalogoPage());

    }

    private void Salir(object sender, EventArgs e)
    {
        // Salir de la aplicaci�n
        App.Current!.MainPage = new NavigationPage(new LoginPage());
    }
}