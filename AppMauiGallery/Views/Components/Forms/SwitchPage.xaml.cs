namespace AppMauiGallery.Views.Components.Forms;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		var switchBottom = (Switch)sender;
		var horizontalStack = (HorizontalStackLayout)switchBottom.Parent;
		var verticalStack = (VerticalStackLayout)horizontalStack.Parent;
		var label = (Label)horizontalStack.Children[1];
		if(e.Value)
		{
			verticalStack.BackgroundColor = Color.FromHex("#000");
			label.TextColor = Color.FromHex("#FFF");
			label.Text = "White Mode";
		}
		else
		{
			verticalStack.BackgroundColor = Color.FromHex("#FFF");
			label.TextColor = Color.FromHex("#000");
			label.Text = "Dark Mode";
		}
    }
}