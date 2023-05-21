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

    private void Seta_Clicked(object sender,EventArgs e) {
        Shell.Current.GoToAsync("seta");
    }

    private void Bus_Clicked(object sender,EventArgs e) {
        Shell.Current.GoToAsync("bus");
    }

    private void Euro_Clicked(object sender,EventArgs e) {
        Shell.Current.GoToAsync("euro");
    }

    private void Sinais_Clicked(object sender,EventArgs e) {
        Shell.Current.GoToAsync("sinais");
    }

    private void Mappoint_Clicked(object sender,EventArgs e) {
        Shell.Current.GoToAsync("map");
    }
}

