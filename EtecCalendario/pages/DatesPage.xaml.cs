using EtecCalendario.classes;
using EtecCalendario.data;
using System.Collections.ObjectModel;
namespace EtecCalendario.pages;

public partial class DatesPage : ContentPage
{
    public Calendar Calendar { get; }

    public ObservableCollection<DateCalendar> Dates { get; }
    public DatesPage(Calendar calendar)
    {
        this.Calendar = calendar;
        this.Dates = [];
        if (File.Exists(Data.DatesPath))
        {
            List<string> data = File.ReadAllLines(Data.DatesPath).ToList();
            foreach (string date in data)
            {
                string[] split = date.Split("|");
                if (split[0] == Calendar.ID.ToString())
                {
                    this.Dates.Add(new DateCalendar(DateTime.Parse(split[1]), split[2]));
                }
            }
        }

        InitializeComponent();

        BindingContext = this;
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewDate(this.Calendar));
    }
}