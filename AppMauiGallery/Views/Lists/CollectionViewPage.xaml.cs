using AppMauiGallery.Views.Lists.Models;
using System.Collections.ObjectModel;

namespace AppMauiGallery.Views.Lists;

public partial class CollectionViewPage : ContentPage
{	ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
	int countMovies = 0;
	public CollectionViewPage()
	{
		InitializeComponent();
		AddTenMovies();
		ColletionViewControl.ItemsSource = movies;
	}

    private async void RefreshView_Refreshing(object sender, EventArgs e)
    {
		((RefreshView)sender).IsRefreshing = true;
		await Task.Delay(2000);
		ColletionViewControl.ItemsSource = MovieList.GetList();
		((RefreshView)sender).IsRefreshing = false;
    }

    private void ColletionViewControl_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
		AddTenMovies();
		
    }

	private void AddTenMovies()
	{
		for(int i = 0; i < 10; i++)
		{
			Movie movie = new Movie
			{
				Id = countMovies++,
				Name = $"Movie {countMovies}" ,
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed vitae nisi eget nunc ultricies cursus.",
				LaunchYear = 2024 ,
				Duration = new TimeSpan(2, 10, countMovies),
			};

			movies.Add(movie);
                
        }
	}
}