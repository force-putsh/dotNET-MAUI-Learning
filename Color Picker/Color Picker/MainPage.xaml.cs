namespace Color_Picker;

public partial class MainPage : ContentPage
{
	bool isRandom;
	public MainPage()
	{
		InitializeComponent();
	}

	private void sldRed_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		if (!isRandom)
		{
            var red = sldRed.Value;
            var green = sldGreen.Value;
            var blue = sldBlue.Value;
            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);
        }
    }

	private void SetColor(Color color)
	{
		btnRandom.BackgroundColor = color;
		Container.BackgroundColor = color;
		lblHex.Text = color.ToHex();
	}

	private void btnRandom_Clicked(object sender, EventArgs e)
	{
		isRandom = true;
		var rand = new Random();
		var color = Color.FromRgb(
            rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
		SetColor(color);
		sldRed.Value = color.Red;
		sldGreen.Value = color.Green;
		sldBlue.Value = color.Blue;
        isRandom = false;
	}
}

