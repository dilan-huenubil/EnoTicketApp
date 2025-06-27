namespace EnoTicket_App.Vistas;

public partial class Carrito : ContentPage
{

    // Variables para almacenar las cantidades de cada producto
    private int cantidadPreventa1 = 0;
    private int cantidadPreventa2 = 0;
    private int cantidadPreventa3 = 0;

    // Precios de preventa
    private const decimal precioPreventa1 = 11000;
    private const decimal precioPreventa2 = 16000;
    private const decimal precioPreventa3 = 21000;

    // Referencias a los labels de cantidad y total
    private Label labelCantidadPreventa1;
    private Label labelCantidadPreventa2;
    private Label labelCantidadPreventa3;
    private Label labelTotal;

    public Carrito()
	{
		InitializeComponent();
        InicializarReferencias();
        ActualizarTotal();
    }


    private void InicializarReferencias()
    {

    }

    // Eventos para Preventa 1
    private void DecrementarPreventa1_Clicked(object sender, EventArgs e)
    {
        if (cantidadPreventa1 > 0)
        {
            cantidadPreventa1--;
            ActualizarCantidadPreventa1();
            ActualizarTotal();
        }
    }

    private void IncrementarPreventa1_Clicked(object sender, EventArgs e)
    {
        cantidadPreventa1++;
        ActualizarCantidadPreventa1();
        ActualizarTotal();
    }

    // Eventos para Preventa 2
    private void DecrementarPreventa2_Clicked(object sender, EventArgs e)
    {
        if (cantidadPreventa2 > 0)
        {
            cantidadPreventa2--;
            ActualizarCantidadPreventa2();
            ActualizarTotal();
        }
    }

    private void IncrementarPreventa2_Clicked(object sender, EventArgs e)
    {
        cantidadPreventa2++;
        ActualizarCantidadPreventa2();
        ActualizarTotal();
    }

    // Eventos para Preventa 3
    private void DecrementarPreventa3_Clicked(object sender, EventArgs e)
    {
        if (cantidadPreventa3 > 0)
        {
            cantidadPreventa3--;
            ActualizarCantidadPreventa3();
            ActualizarTotal();
        }
    }

    private void IncrementarPreventa3_Clicked(object sender, EventArgs e)
    {
        cantidadPreventa3++;
        ActualizarCantidadPreventa3();
        ActualizarTotal();
    }

    // Métodos para actualizar las cantidades en la UI
    private void ActualizarCantidadPreventa1()
    {
        // Buscar el label de cantidad de preventa 1 y actualizarlo
        var label = this.FindByName<Label>("LabelCantidadPreventa1");
        if (label != null)
            label.Text = cantidadPreventa1.ToString();
    }

    private void ActualizarCantidadPreventa2()
    {
        var label = this.FindByName<Label>("LabelCantidadPreventa2");
        if (label != null)
            label.Text = cantidadPreventa2.ToString();
    }

    private void ActualizarCantidadPreventa3()
    {
        var label = this.FindByName<Label>("LabelCantidadPreventa3");
        if (label != null)
            label.Text = cantidadPreventa3.ToString();
    }

    // Método para calcular y actualizar el total
    private void ActualizarTotal()
    {
        decimal total = (cantidadPreventa1 * precioPreventa1) +
                       (cantidadPreventa2 * precioPreventa2) +
                       (cantidadPreventa3 * precioPreventa3);

        var labelTotal = this.FindByName<Label>("LabelTotal");
        if (labelTotal != null)
            labelTotal.Text = $"${total:N0}";
    }



    // Eventos para los botones de eliminar producto
    private void EliminarPreventa1_Clicked(object sender, EventArgs e)
    {
        cantidadPreventa1 = 0;
        ActualizarCantidadPreventa1();
        ActualizarTotal();
    }

    private void EliminarPreventa2_Clicked(object sender, EventArgs e)
    {
        cantidadPreventa2 = 0;
        ActualizarCantidadPreventa2();
        ActualizarTotal();
    }

    private void EliminarPreventa3_Clicked(object sender, EventArgs e)
    {
        cantidadPreventa3 = 0;
        ActualizarCantidadPreventa3();
        ActualizarTotal();
    }


    private async void ButtonBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void ButtonEVVM_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EValleMaipo());
    }


}