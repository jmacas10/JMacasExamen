namespace JMacasExamen.Vistas;

public partial class Login : ContentPage
{
    // Vectores que almacenan nombres de los usuarios y contrase�as
    string users;
    string passwords;
    string[] usuarios = { "estudiante2024", "examen1", "jmacas" };
    string[] contrasenas = { "uisrael2024", "parcial1", "2024" };
    public Login()
	{
		InitializeComponent();
	}
    public Login(string usuario, string contrasena)
    {
        InitializeComponent();
        users = usuario;
        passwords = contrasena;

    }

    private void InicioSesion_Clicked(object sender, EventArgs e)
    {
        users = txtUsuario.Text;
        passwords = txtContrase�a.Text;

        bool usuarioValido = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == users && contrasenas[i] == passwords)
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
        {
            Navigation.PushAsync(new Vregistro(users));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/contrase�a incorrecto", "Cerrar");
            //txtUsuario.Text = "";
            //txtContrase�a.Text = "";
        }
    }

    private void acercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaDE());
    }
}