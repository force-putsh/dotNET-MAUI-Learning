namespace dotnet_MAUI_Pages;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	private void btnGO_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());

	}
}