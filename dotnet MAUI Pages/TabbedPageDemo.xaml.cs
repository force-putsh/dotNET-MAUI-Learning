namespace dotnet_MAUI_Pages;

public partial class TabbedPageDemo : TabbedPage
{
    public TabbedPageDemo()
    {
        InitializeComponent();
        //Children.Add(new Page());
        //Children.Add(new Page());
        //Children.Add(new Page());
    }

    private void btnOK_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlyoutPageDemo());
    }
}