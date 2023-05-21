namespace Bus4All;

public partial class Mapa : ContentPage
{
    bool x;
    public Mapa()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender,EventArgs e) {
        if(!x) {
            DisplayAlert("Alerta","O seu Autocarro encontra-se a 2km de si","OK");
            await Task.Delay(2000);
            await Vibrates(1000);
            await Vibrates(1000);
        }
        if(x) {
            DisplayAlert("Alerta","O seu Autocarro encontra-se a 300 m de si","OK");
            await Task.Delay(2000);
            await Vibrates(250);
            await Vibrates(250);
            await Vibrates(250);
        }
        x = !x;
    }

    async private Task Vibrates(double x) {
        Vibration.Default.Vibrate(x);
        int delay = Convert.ToInt32( x + (x * 0.5));
        await Task.Delay(delay);
    }
}