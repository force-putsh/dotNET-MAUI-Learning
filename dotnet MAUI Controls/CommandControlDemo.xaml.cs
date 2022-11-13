namespace dotnet_MAUI_Controls;

public partial class CommandControlDemo : ContentPage
{
	public CommandControlDemo()
	{
		InitializeComponent();
	}

	private void btnTest_Clicked(object sender, EventArgs e)
	{
		if (sender is Button)
		{
            DisplayAlert("Test", $"The button {(sender as Button).Text} was clicked at {DateTime.Now}", "OK");
        }
        else
        {
            DisplayAlert("Test", $"The {sender.GetType()} was clicked at {DateTime.Now}", "OK");
        }
    }

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{

	}

	private void searchControl_SearchButtonPressed(object sender, EventArgs e)
	{

	}

	private void SwipeItem_Invoked(object sender, EventArgs e)
	{

	}
}