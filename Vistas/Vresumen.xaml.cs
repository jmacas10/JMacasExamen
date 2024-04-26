namespace JMacasExamen.Vistas;

public partial class Vresumen : ContentPage
{
	
	public Vresumen(string usuario,string[]resumendatos)
	{
		InitializeComponent();
		lblUsuarioConectadoregistro.Text = usuario;
		txtnombre.Text = resumendatos[0];
		txtApellido.Text = resumendatos[1];
		lbledad.Text = resumendatos[2];
		lblfecha.Text = resumendatos[3];
		lblciudad.Text = resumendatos[4];
		

	}
}