namespace JMacasExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
           // MainPage = new  Vistas.Login();
            MainPage = new NavigationPage(new Vistas.Login());

        }
    }
}
