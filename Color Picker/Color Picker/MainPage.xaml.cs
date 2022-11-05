namespace Color_Picker;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void sldRed_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		var red = sldRed.Value;
		var green = sldGreen.Value;
		var blue = sldBlue.Value;

		Color color = Color.FromRgb(red, green, blue);

		setColor(color);
    }

	private void setColor(Color color)
	{
		btnRandom.BackgroundColor = color;
		Container.BackgroundColor = color;
		lblHex.Text = color.ToHex();
	}
}

