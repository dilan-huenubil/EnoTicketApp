namespace EnoTicket_App.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void btnCrearCuenta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Register());
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Home());
    }
}