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
}