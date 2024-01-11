namespace AppMauiGallery.Views.Components.Forms;

public partial class EntryPage : ContentPage
{
	public EntryPage()
	{
		InitializeComponent();
		
		
		
	}

    
    private void NameEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        lblTextName.Text = $"Old name {e.OldTextValue} - New name {e.NewTextValue}";
    }

    private void NameEntry_Completed(object sender, EventArgs e)
    {
        LblTextPassword.Text =$"Name Final: {NameEntry.Text}";
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        LblTextPassword.Text = $"Password: {PasswordEntry.Text}";
    }

    private void Entry_Completed_1(object sender, EventArgs e)
    {
       LblTextPhone.Text = $"Phone: {PhoneEntry.Text}";
    }
}