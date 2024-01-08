namespace AppFlyoutPage;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void OnClickedPageOne(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page1());
    }

    private void OnClickedPageTwo(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail =  new NavigationPage( new Page2());
    }

    private void OnClickedPageThree(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Page3());
    }
}