namespace AppMauiGallery.Views.Cells;

public partial class SwitchCellPage : ContentPage
{
	public SwitchCellPage()
	{
		InitializeComponent();
	}

    private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
    {
		if(e.Value)
		{
			DisplayAlert("config", "Modo n�o pertube ligado", "OK");
		}
		else
		{
			DisplayAlert("config", "Modo n�o pertube desligado", "OK");
		}
    }
}