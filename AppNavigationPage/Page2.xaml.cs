namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void OnButtomNextClicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page3());
    }

    private void OnButtomPreviewClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}