namespace MeteoApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.PersonnalCityPage), typeof(Views.PersonnalCityPage));
    }
}
