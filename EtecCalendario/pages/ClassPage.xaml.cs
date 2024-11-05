using EtecCalendario.classes;
using System.Collections.ObjectModel;
using EtecCalendario.data;
namespace EtecCalendario.pages;

public partial  class ClassPage : ContentPage
{
	public ObservableCollection<Calendar> Dates { get; set; }
	public ClassPage()
	{
		
		InitializeComponent();
		      //Data.Calendars.Add(new Calendar("teste.svg", "BD"));
		//DisplayAlert("rfrf", $"{Data.Calendars[0].Class} / {Data.Calendars[0].Subject}","thyhyhyh");
		this.Dates = new ObservableCollection<Calendar>();
		foreach (var calendar in Data.Calendars)
		{
             this.Dates.Add(calendar);
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

  
}