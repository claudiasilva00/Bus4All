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

    private void Estrela_Clicked(object sender,EventArgs e) {

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

