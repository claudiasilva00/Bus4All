namespace Bus4All;

public partial class Horarios : ContentPage
{
	public Horarios()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("sinais");
    }
}