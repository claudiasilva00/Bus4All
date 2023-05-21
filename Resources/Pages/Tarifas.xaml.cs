namespace Bus4All;

public partial class Tarifas : ContentPage
{
	public Tarifas()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

        DisplayAlert("ZONAS             PREÇOS", "       1                           xx,xx€\n" +
            "       2                           xx,xx€\n" +
            "       3                           xx,xx€\n" +
            "       4                           xx,xx€", "OKAY");


        //priceTableGrid.IsVisible = true;

    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        //priceTableGrid.IsVisible = false;
    }
}