using AppMauiGallery.Views.Lists.Models;

namespace AppMauiGallery.Views.Lists;

public partial class CarouselViewPage : ContentPage
{
	public CarouselViewPage()
	{
		InitializeComponent();
		CarouselViewControl.ItemsSource = MovieList.GetList();
	}
}