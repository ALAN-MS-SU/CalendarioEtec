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
		Data.Calendars.Add(new Calendar { Class = "SURGE",Subject = "KITSUNAMI" });
		//      Data.Calendars.Add(new Calendar("teste.svg", "BD"));
		//DisplayAlert("rfrf", $"{Data.Calendars[0].Class} / {Data.Calendars[0].Subject}","thyhyhyh");
		this.Dates = new ObservableCollection<Calendar>();
		foreach (var calendar in Data.Calendars)
		{
             this.Dates.Add(calendar);
		}
		BindingContext = this;
	}
}