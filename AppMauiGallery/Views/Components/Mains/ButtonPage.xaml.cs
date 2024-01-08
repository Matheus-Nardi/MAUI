namespace AppMauiGallery.Views.Components.Mains;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		LblLog.Text += $"Meu but�o foi clicado as {DateTime.Now:g}\n";
    }

    private void Butao_Pressed(object sender, EventArgs e)
    {
        LblLog.Text += $"Meu but�o foi pressionado as {DateTime.Now:g}\n";
    }

    private void Butao_Released(object sender, EventArgs e)
    {
        LblLog.Text += $"Liberou meu bot�o as {DateTime.Now:g} \n";

    }
}