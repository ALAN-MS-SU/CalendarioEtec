using EtecCalendario.classes;
using System.Collections.ObjectModel;
using System.Windows.Input;
namespace EtecCalendario.pages;

public partial class DatesPage : ContentPage
{
    public Calendar Calendar { get; }

    public ObservableCollection<DateCalendar> Dates { get; }

    public ICommand Delet { get; }
    public DatesPage(Calendar calendar)
    {
        this.Calendar = calendar;
        this.Dates = [];
        this.Delet = new Command<DateCalendar>((Date) => { Delet_Date(Date); });



        if (File.Exists(DateCalendar.DatesPath))
        {
            string[] data = File.ReadAllLines(DateCalendar.DatesPath);

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
    private async void Delet_Date(DateCalendar Date)
    {

        string g = DateCalendar.Delet_Date(Date);
        await DisplayAlert("lop", g, "juki");
        await Navigation.PushAsync(new DatesPage(Calendar));
    }
    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClassPage());

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewDate(this.Calendar));
    }
}