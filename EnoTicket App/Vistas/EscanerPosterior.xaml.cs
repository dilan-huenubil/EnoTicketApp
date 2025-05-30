using Microsoft.Maui.Controls;
using Microsoft.Maui.Media;
namespace EnoTicket_App.Vistas;

public partial class EscanerPosterior : ContentPage
{
	public EscanerPosterior()
	{
		InitializeComponent();

        // Eventos
        var tapCamara = new TapGestureRecognizer();
        tapCamara.Tapped += async (s, e) => await TomarFoto();

        var tapGaleria = new TapGestureRecognizer();
        tapGaleria.Tapped += async (s, e) => await ElegirDesdeGaleria();

        BotonCamara.GestureRecognizers.Add(tapCamara);
        BotonGaleria.GestureRecognizers.Add(tapGaleria);
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
                    await Navigation.PushAsync(new EscanerBiometrico());
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

    private async Task ElegirDesdeGaleria()
    {
        try
        {
            FileResult photo = await MediaPicker.Default.PickPhotoAsync();
            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
                imagenCarnet.Source = ImageSource.FromStream(() => stream);
                imagenCarnet.IsVisible = true;
                await Navigation.PushAsync(new EscanerBiometrico());
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudo seleccionar la imagen: {ex.Message}", "OK");
        }
    }
}