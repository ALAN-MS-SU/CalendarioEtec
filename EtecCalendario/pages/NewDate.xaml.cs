using EtecCalendario.classes;
namespace EtecCalendario.pages;

public partial class NewDate : ContentPage
{
    private Calendar Calendar { get; }
    public NewDate(Calendar calendar)
    {
        this.Calendar = calendar;
        InitializeComponent();
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(this.Calendar.ID) && !string.IsNullOrEmpty(Date.Date.ToString()) && !string.IsNullOrEmpty(Subject.Text))
        {
            StreamWriter writer = new(DateCalendar.DatesPath, true);
            writer.WriteLine($"{this.Calendar.ID}|{Date.Date}|{Subject.Text}");
            writer.Close();
            await Navigation.PushAsync(new DatesPage(this.Calendar));

        }
    }
}