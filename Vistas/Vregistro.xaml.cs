namespace JMacasExamen.Vistas;

public partial class Vregistro : ContentPage
{
	public Vregistro( string usuario)
	{
		InitializeComponent();
        DisplayAlert("OK", " Bien Venido: " + usuario, "Cerrar");
        lblUsuarioConectado.Text = " Usuario Conectado: " + usuario;
    }

    private void calcularIngreso_Clicked(object sender, EventArgs e)
    {

    }

    private void resumen_Clicked(object sender, EventArgs e)
    {


        Navigation.PushAsync(new Vresumen());
    }
}