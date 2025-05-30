using Microsoft.Maui.Controls;
using Microsoft.Maui.Media;
namespace EnoTicket_App.Vistas;

public partial class EscanerBiometrico : ContentPage
{
	public EscanerBiometrico()
	{
		InitializeComponent();

        // Eventos
        var tapCamara = new TapGestureRecognizer();
        tapCamara.Tapped += async (s, e) => await TomarFoto();


        BotonCamara.GestureRecognizers.Add(tapCamara);

    }

    private async Task TomarFoto()
    {
        try
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
                if (photo != null)
                {
                    var stream = await photo.OpenReadAsync();
                    imagenCarnet.Source = ImageSource.FromStream(() => stream);
                    imagenCarnet.IsVisible = true;
                    await Navigation.PushAsync(new Login());
                }
            }
            else
            {
                await DisplayAlert("No disponible", "La cámara no está disponible.", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudo tomar la foto: {ex.Message}", "OK");
        }
    }
}