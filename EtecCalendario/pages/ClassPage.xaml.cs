using EtecCalendario.classes;
using System.Collections.ObjectModel;
using EtecCalendario.data;
namespace EtecCalendario.pages;

public partial class ClassPage : ContentPage
{
    public ObservableCollection<Calendar> Classes { get; set; }

    public ClassPage()
    {

        InitializeComponent();
        this.Classes = [];
        //File.Create($"{FileSystem.AppDataDirectory}/data.txt");
        //StreamWriter writer = new(Calendar.CalendarsPath,true);


       // writer.Close();

        //writer.WriteLine("SURGE");
        //File.Delete($"{FileSystem.AppDataDirectory}/data.txt");

        //foreach (var calendar in Data.Calendars)
        //{
        string[] data = File.ReadAllLines($"{FileSystem.AppDataDirectory}/Calendars.txt");
        foreach (var calendar in data)

            this.Classes.Add(new Calendar(calendar.Split("|")[0], calendar.Split("|")[1]));
        //}
        BindingContext = this;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewClass());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void list_Calendars_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }
}