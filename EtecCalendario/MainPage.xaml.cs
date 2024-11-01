using CommunityToolkit;
using EtecCalendario.classes;
using EtecCalendario.pages;
namespace EtecCalendario
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
          
        }

        private async void ClassButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClassPage());
        }
    }

}
