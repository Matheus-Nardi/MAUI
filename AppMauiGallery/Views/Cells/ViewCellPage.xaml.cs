namespace AppMauiGallery.Views.Cells;

public partial class ViewCellPage : ContentPage
{
	public ViewCellPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		infoWorker.IsVisible = false;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        infoWorker.IsVisible = true;
    }
}