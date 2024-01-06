namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void ShowPages(object sender, EventArgs e)
	{
		NameApp.IsVisible = false;
        ContainerNumbers.IsVisible = true;

		var set = RandomNumbers();
		LuckNumber01.Text = set.ElementAt(0).ToString("D2");
		LuckNumber02.Text = set.ElementAt(1).ToString("D2");
		LuckNumber03.Text = set.ElementAt(2).ToString("D2");
		LuckNumber04.Text = set.ElementAt(3).ToString("D2");
		LuckNumber05.Text = set.ElementAt(4).ToString("D2");
		LuckNumber06.Text = set.ElementAt(5).ToString("D2");
    }

	private SortedSet<int> RandomNumbers()
	{
		//SortedSet = não deixa repitir e deixa ordenada
		var set = new SortedSet<int>();

		 while(set.Count < 6) { 
			Random ale = new Random();
			var luckNumber = ale.Next(1 ,60);

			set.Add(luckNumber);
			
		 }
		return set;
	}

    
}