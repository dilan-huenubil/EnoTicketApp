namespace EnoTicket_App.Vistas;

public partial class CarritoVacio : ContentPage
{
	public CarritoVacio()
	{
		InitializeComponent();
	}

    private async void ButtonBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}