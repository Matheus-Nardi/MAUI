namespace AppNavigationPage;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void OnPreviewButtonClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    
}