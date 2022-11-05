using System.Diagnostics;

namespace dotnet_MAUI_Controls;

public partial class InputControlDemo : ContentPage
{
	public InputControlDemo()
	{
		InitializeComponent();
	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		Debug.WriteLine((int)slider.Value);

	}

	private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
        if (stepper!= null)
        {
            Debug.WriteLine((int)stepper.Value);
        }
    }
}