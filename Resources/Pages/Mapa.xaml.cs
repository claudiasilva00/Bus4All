namespace Bus4All;

public partial class Mapa : ContentPage
{
	public Mapa()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender,EventArgs e) {
		DisplayAlert("Alerta","O seu Autocarro encontra-se a 2km de si","OK");
        Vibration.Default.Vibrate(1000);
        Thread.Sleep(1500);
        Vibration.Default.Vibrate(1000);
        Thread.Sleep(1500);
        //// DisplayAlert("Alerta","O seu Autocarro encontra-se a 300 m de si","OK");
        // Vibration.Default.Vibrate(100);
        // Vibration.Default.Vibrate(100);
        // Vibration.Default.Vibrate(100);
    }
}