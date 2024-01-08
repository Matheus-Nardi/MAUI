using System.Timers;

namespace AppMauiGallery.Views.Components.Mains;

public partial class ImageButtonPage : ContentPage
{
	;
	bool buttonState = false;
	bool lampState = false;
	public ImageButtonPage()
	{
		InitializeComponent();
       
    }

    private void ImageButtonPowerOff_Clicked(object sender, EventArgs e)
    {
		buttonState = !buttonState;

		var powerOff = "poweroff.png";
		var powerOn = "poweron.png";

		var button = (ImageButton)sender;
		button.Source = buttonState ? ImageSource.FromFile(powerOn) : ImageSource.FromFile(powerOff);
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		lampState = !lampState;

		var lampOff = "lampadadesligada.png";
		var lampOn = "lampadaligada.png";

        var button = (ImageButton)sender;
        button.Source = lampState ? ImageSource.FromFile(lampOn) : ImageSource.FromFile(lampOff);
    }

    private void ImageButton_Pressed(object sender, EventArgs e)
    {
        var button = (ImageButton)sender;
        button.Source = ImageSource.FromFile("lampadadesligada.png");
    }

    
}