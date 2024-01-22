using AppMauiGallery.Views.Lists.Models;

namespace AppMauiGallery.Views.Lists;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

		ListViewControl.ItemsSource = MovieList.GetGroupList().Take(2);
       
    }

    private void ListViewControl_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
     
      var movie =  (Movie)e.SelectedItem;
      

        App.Current.MainPage.DisplayAlert( "Good Choise" , $"Filme selecionado {movie.Name}","OK");
    }

    private async void ListViewControl_Refreshing(object sender, EventArgs e)
    {
        ListViewControl.IsRefreshing = true;
        await Task.Delay(1500);
        ListViewControl.ItemsSource = MovieList.GetGroupList();

        ListViewControl.IsRefreshing = false;
    }
}