namespace EnoTicket_App.Vistas;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    private async void ButtonRegister_Clicked(object sender, EventArgs e)
    {
        DateTime fechaNacimiento = datePickerFechaNacimiento.Date;
        int edad = DateTime.Today.Year - fechaNacimiento.Year;
        if (fechaNacimiento > DateTime.Today.AddYears(-edad)) edad--;

        if (edad < 18)
        {
            await DisplayAlert("Edad insuficiente", "Debes tener al menos 18 años para registrarte.", "OK");
            return;
        }


        await Navigation.PushAsync(new Escaner());
    }
}