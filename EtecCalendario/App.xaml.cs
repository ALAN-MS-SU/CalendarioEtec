using EtecCalendario.pages;
namespace EtecCalendario
{
    public partial class App : Application
    {
        public App()
        {
            
            InitializeComponent();
            NavigationPage Navigation = new(new ClassPage())
            {
                BarBackgroundColor = Colors.White,
                BarTextColor = Colors.White
            };
            MainPage = Navigation;
        }
    }
}
