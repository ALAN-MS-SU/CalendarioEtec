using EtecCalendario.data;


using EtecCalendario.classes;
namespace EtecCalendario.pages;

public partial class NewClass : ContentPage
{
    public NewClass()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        StreamWriter writer = new(Data.CalendarsPath,true);

        writer.WriteLine($"{Class.Text}|{Subject.Text}");

        writer.Close();
        
        await Navigation.PushAsync(new ClassPage());

    }
}