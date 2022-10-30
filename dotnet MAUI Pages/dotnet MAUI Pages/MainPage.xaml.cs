namespace dotnet_MAUI_Pages;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new ContentPageDemo());
    }
}

