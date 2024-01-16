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
			verticalStack.BackgroundColor = Color.FromArgb("#000");
			label.TextColor = Color.FromArgb("#FFF");
			label.Text = "White Mode";
		}
		else
		{
			verticalStack.BackgroundColor = Color.FromArgb("#FFF");
			label.TextColor = Color.FromArgb("#000");
			label.Text = "Dark Mode";
		}
    }
}