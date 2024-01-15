namespace AppMauiGallery.Views.Components.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

    private void Slider_DragStarted(object sender, EventArgs e)
    {
        LblStatus.Text = "Iniciou o arrastar";
    }

    private void Slider_DragCompleted(object sender, EventArgs e)
    {
        LblStatus.Text = "Finalizou o arrastar";
        
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        LblValue.Text = $"Valor atual: R${(int)e.NewValue}";
    }
}