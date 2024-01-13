namespace AppMauiGallery.Views.Components.Forms;

public partial class RadioButtonPage : ContentPage
{
	public RadioButtonPage()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if(e.Value == true)
		{
			var answer = ((RadioButton)sender).Content;
			LblResultAks02.Text = $"You have selected {answer}";
		}
    }
}