namespace AppMauiGallery.Views.Components.Forms;

public partial class CheckBoxPage : ContentPage
{
	public CheckBoxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
		{
			List<string> checkBoxList = new List<string>();
			CheckBox checkBox = (CheckBox)sender;
			HorizontalStackLayout stack = (HorizontalStackLayout)checkBox.Parent;
			Label label = (Label)stack.Children[1];
			checkBoxList.Add(label.Text);
			
			LblChoise.Text = string.Join(", ", checkBoxList);
		}
		else
			LblChoise.Text = string.Empty;
			
    }

    private void TodoList(object sender, CheckedChangedEventArgs e)
    {
			DateTime timeCheck = DateTime.Now;
		    
			CheckBox checkBox = (CheckBox)sender;
			HorizontalStackLayout stack = (HorizontalStackLayout)checkBox.Parent;
			Label label = (Label)(stack.Children[1]);
			Label secondLabel = (Label)(stack.Children[2]);

		if(e.Value)
		{
			Label strike = new Label { Text = $"{label.Text}" , TextDecorations = TextDecorations.Strikethrough};
			Label time = new Label { Text = $"Feito as {timeCheck.ToShortTimeString()}" , TextDecorations = TextDecorations.None};
			strike.VerticalOptions = LayoutOptions.Center;
			time.VerticalOptions = LayoutOptions.End;
			time.HorizontalOptions = LayoutOptions.End;
			
			stack.Children[1] = strike;
			stack.Children[2] = time;
		}
		else
		{
            Label noStrike = new Label { Text = $"{label.Text}", TextDecorations = TextDecorations.None };
            noStrike.VerticalOptions = LayoutOptions.Center;
			stack.Children[1] = noStrike;

        }

    }
}