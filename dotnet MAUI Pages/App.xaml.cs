namespace dotnet_MAUI_Pages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var navPage = new NavigationPage(new MainPage());
		navPage.Background = Colors.Green;
		//MainPage = new NavigationPage(new MainPage());
		//MainPage = new FlyoutPageDemo();                         
		MainPage = new NavigationPage(new TabbedPageDemo());
    }
}
