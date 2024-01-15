namespace AppMauiGallery.Views.Components.Forms;

public partial class DatePickerPage : ContentPage
{
	public DatePickerPage()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		lblDateSelected.Text =  $"Date Selected: { e.NewDate.ToString("dd/MM/yyyy")}";
		var date = e.NewDate;
		if(DateTime.Now.Year - date.Year > 18)
		{
			DisplayAlert("Alert", "You are over 18 years old", "Ok");
		}
    }
}