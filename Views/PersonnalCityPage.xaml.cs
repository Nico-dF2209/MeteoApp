using MeteoApp.Models;


namespace MeteoApp.Views;
[QueryProperty(nameof(Targetcity), nameof(Targetcity))]
public partial class PersonnalCityPage : ContentPage
{
	public City Targetcity
	{
		set { LoadCity(value); }

	}
	public PersonnalCityPage()
	{
		InitializeComponent();

		//BindingContext = new MeteoCity();
	}

	public async void LoadCity(City city)
	{
		BindingContext = new MeteoCity(city.Latitude, city.Longitude);
		Meteo meteo = new Meteo();

		
        
       // MeteoCity.SearchMeteo(meteo.lat, meteo.lon);
        BindingContext = meteo;
	}
	
}