namespace AppJogoDaForca;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void Buttom_Start(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void Button_Exit(object sender, EventArgs e)
    {
        System.Environment.Exit(0);
    }

}