namespace Bus4All;

public partial class Mapa : ContentPage
{
	public Mapa()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender,EventArgs e) {
		DisplayAlert("Alerta","O seu Autocarro encontra-se a 2km de si","OK");
        await Vibrates(1000);
        await Vibrates(1000);
        //// DisplayAlert("Alerta","O seu Autocarro encontra-se a 300 m de si","OK");
        // Vibration.Default.Vibrate(100);
        // Vibration.Default.Vibrate(100);
        // Vibration.Default.Vibrate(100);
    }

    async private Task Vibrates(double x) {
        Vibration.Default.Vibrate(x);
        int delay =Convert.ToInt32( x + (x * 0.5));
        await Task.Delay(delay);
    }
}