namespace JMacasExamen.Vistas;

public partial class Vregistro : ContentPage
{
    string[] resumendatos;
	public Vregistro( string usuario)
	{
		InitializeComponent();
        DisplayAlert("OK", " Bien Venido: " + usuario, "Cerrar");
        lblUsuarioConectado.Text = " Usuario Conectado: " + usuario;
    }

    private void calcularIngreso_Clicked(object sender, EventArgs e)
    {
        double costo = 1500;
        string nombre = txtnombre.Text;
        string apellido = txtapellido.Text;
        string edad=txtedad.Text;
        double Minicial = double.Parse(txtmonto.Text);//monto inicial
        double cuotamensual = 0;
        double pagototal = 0;

        //
        string fechaActual = dpfechas.Date.ToString("dd/MM/yyyy");
        string pais = pkPais.AnchorX.ToString();
        string ciudad =pkCiudad.AnchorX.ToString();


        cuotamensual = ((costo - Minicial) / 4) + (1500 * 0.04);
        pagototal = (4 * cuotamensual) + Minicial;

        txtpago.Text = cuotamensual.ToString();

        resumendatos = new string[] { nombre, apellido };//,edad,fechaActual,ciudad,pais

    }

    private void resumen_Clicked(object sender, EventArgs e)
    {
        
        Navigation.PushAsync(new Vresumen(lblUsuarioConectado.Text,resumendatos));
    }
}