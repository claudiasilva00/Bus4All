using Bus4All;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.Xaml;
namespace Bus4All;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
        
    }

    private async void Seta_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("seta");
    }

    private async void Bus_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("bus");
    }

    private async void Euro_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("euro");
    }

    private async void Sinais_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("selec");
    }

    private async void Mappoint_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("map");
    }
}

