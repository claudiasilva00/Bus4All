namespace Bus4All;

public partial class Horarios : ContentPage
{
	public Horarios()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
        await Shell.Current.GoToAsync("selec");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {

            await Shell.Current.GoToAsync("..");
            await Shell.Current.GoToAsync("map");

    }
}