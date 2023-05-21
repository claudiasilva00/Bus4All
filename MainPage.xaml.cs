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

    async private void Seta_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("seta");
    }

    async private void Bus_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("bus");
    }

    async private void Euro_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("euro");
    }

    async private void Sinais_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("sinais");
    }

    async private void Mappoint_Clicked(object sender,EventArgs e) {
        await Shell.Current.GoToAsync("map");
    }

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	Shell.Current.GoToAsync("about");

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

