using Microsoft.Maui.Maps;

namespace StudyingMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

  //  protected override async void OnAppearing()
  //  {
		//base.OnAppearing();

		//var geolocationRequest = new GeolocationRequest(GeolocationAccuracy.High, TimeSpan.FromSeconds(10));
		//var response = await Geolocation.GetLocationAsync(geolocationRequest);

		//map.MoveToRegion(MapSpan.FromCenterAndRadius(response, Distance.FromMiles(10)));
  //  }
}

