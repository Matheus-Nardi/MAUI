namespace AppMauiGallery.Views.Components.Forms;

public partial class SearchBarPage : ContentPage
{
	public SearchBarPage()
	{
		InitializeComponent();
        
	}
		
    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
		var value = ((SearchBar)sender).Text;
		
		LblSearch.Text = $"Você pesquisou por: {value}";
		
    }

   



}