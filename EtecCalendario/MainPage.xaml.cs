using CommunityToolkit;
using EtecCalendario.classes;
using EtecCalendario.pages;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;
namespace EtecCalendario
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            //StreamWriter teste = new($"{FileSystem.AppDataDirectory}/data.txt");
            //teste.WriteLine("SURGE");
            //teste.Close();
           // File.Delete($"{FileSystem.AppDataDirectory}/Calendars.txt");


        }

        private async void ClassButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClassPage());
        }
    }

}
