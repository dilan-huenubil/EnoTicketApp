namespace EnoTicket_App.Vistas;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private async  void ButtonCuenta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MiCuenta());
    }

    private async void ButtonEVVM_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EValleMaipo());
    }

    private async void ButtonCarrito_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CarritoVacio());
    }
}