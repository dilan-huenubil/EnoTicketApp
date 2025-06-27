namespace EnoTicket_App.Vistas;

public partial class EValleMaipo : ContentPage
{
	public EValleMaipo()
	{
		InitializeComponent();
	}

    private async void ButtonBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void ButtonC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Carrito());
    }
}