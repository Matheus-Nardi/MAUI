namespace AppMauiGallery.Views.Components.Forms;

public partial class PickerPage : ContentPage
{
	
	public PickerPage()
	{
		
		InitializeComponent();
		

	}

	private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var component = ((Picker)sender);
		var selectedItem = (string)component.SelectedItem;
		

		LblValue.Text = $" Marca selecionada : {selectedItem}";
    }

   
}