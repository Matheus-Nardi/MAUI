namespace AppMauiGallery.Views.Components.Forms;

public partial class StepperPage : ContentPage
{
	public StepperPage()
	{
		InitializeComponent();
	}

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		var stepper = (Stepper)sender;
		var horizontalStack = (HorizontalStackLayout)stepper.Parent;
		var label = (Label)horizontalStack.Children[1];

		label.Text = $"Old value {e.OldValue} - New Value {e.NewValue}";

	}
}