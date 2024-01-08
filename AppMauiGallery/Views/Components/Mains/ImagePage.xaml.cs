namespace AppMauiGallery.Views.Components.Mains;

public partial class ImagePage : ContentPage
{
	public ImagePage()
	{
		InitializeComponent();
		//As imagems podem ter diferentes origines usando o from : stream, file, uri, resource
		//
		//ImagemAnime.Source = ImageSource.FromResource("AppMauiGallery.Assets.Images.anime.jpg");
	}
}