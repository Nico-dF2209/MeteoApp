using MeteoApp.Models;
namespace MeteoApp.Views;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();

		BindingContext = new CitySearchResult();
	}

    private async void SearchClicked(object sender, EventArgs e)
    {
		(BindingContext as CitySearchResult).SearchCity(SearchCityBar.Text);
		
    }

    private async void Selection_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if(e.SelectedItem != null && e.SelectedItem is City city)
        {
        	Dictionary<string, object> navigationParameter = new();
        	navigationParameter.Add(nameof(PersonnalCityPage.Targetcity), city);

        	await Shell.Current.GoToAsync(nameof(PersonnalCityPage), navigationParameter);
            Selection.SelectedItem = null;
        	(BindingContext as CitySearchResult).SearchResults.Clear();
        } 
    }
}