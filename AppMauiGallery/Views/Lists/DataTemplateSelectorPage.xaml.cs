using AppMauiGallery.Views.Lists.Models;

namespace AppMauiGallery.Views.Lists;

public partial class DataTemplateSelectorPage : ContentPage
{
	public DataTemplateSelectorPage()
	{
		InitializeComponent();
		CollectionControl.ItemsSource = MovieList.GetList();
	}

	
}