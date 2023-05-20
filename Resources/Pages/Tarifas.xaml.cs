namespace Bus4All;

public partial class Tarifas : ContentPage
{
	public Tarifas()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        priceTableGrid.IsVisible = true;

    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        priceTableGrid.IsVisible = false;
    }
}