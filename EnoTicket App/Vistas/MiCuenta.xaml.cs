namespace EnoTicket_App.Vistas;

public partial class MiCuenta : ContentPage
{
	public MiCuenta()
	{
		InitializeComponent();
	}

    private async void ButtonLogout_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }
}