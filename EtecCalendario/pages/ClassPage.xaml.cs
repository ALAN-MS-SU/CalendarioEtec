using EtecCalendario.classes;
using System.Collections.ObjectModel;
using EtecCalendario.data;
using CommunityToolkit;
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
        //{}
        if (File.Exists(Data.CalendarsPath))
        {
            string[] data = File.ReadAllLines(Data.CalendarsPath);
            foreach (var calendar in data)
            {
                var split = calendar.Split("|");
                this.Classes.Add(new Calendar(split[0], split[1], split[2]));
            }
        }

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

    private async void list_Calendars_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var view = e.Item as Calendar;
        
        await Navigation.PushAsync(new DatesPage(view));
    }
}