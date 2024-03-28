namespace SetTitleIconImageSourceCrash;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        NavigationPage.SetTitleIconImageSource(this, "dotnet_bot.png");
    }
}


