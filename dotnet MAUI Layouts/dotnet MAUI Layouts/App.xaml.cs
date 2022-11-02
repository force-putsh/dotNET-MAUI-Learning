namespace dotnet_MAUI_Layouts;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new StackLayoutDemo();
		//MainPage = new HorizontalStackLayoutDemo();
		MainPage = new GridLayoutDemo();
	}
}
