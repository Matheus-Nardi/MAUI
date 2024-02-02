using AppMauiGallery.Repositories;
namespace AppMauiGallery.Views;

public partial class Menu : ContentPage
{
	IGroupComponentRepository _repository;
	public Menu()
	{
		InitializeComponent();
		_repository = new GroupComponentRepository();
		MenuCollection.ItemsSource = _repository.GetGroupComponents();

		//TODO - DEPENDENCY INJECTION
		

		
		
	}

    private void OnTapConponent(object sender, TappedEventArgs e)
    {

		var page = (Type)e.Parameter;

		((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage( (Page)Activator.CreateInstance(page));
		((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void OnTapHome(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMauiGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}