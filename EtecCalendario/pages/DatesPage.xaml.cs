using EtecCalendario.classes;

namespace EtecCalendario.pages;

public partial class DatesPage : ContentPage
{
	public  Calendar Calendar;
	public DatesPage(Calendar calendar)
	{
		this.Calendar = calendar;
		InitializeComponent();
		
        BindingContext = (this.Calendar);
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}