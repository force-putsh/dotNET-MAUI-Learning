namespace dotnet_MAUI_Controls;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();
        //MainPage = new ControlToPresentData();
        //MainPage = new CommandControlDemo();
        MainPage = new InputControlDemo();
    }
}
