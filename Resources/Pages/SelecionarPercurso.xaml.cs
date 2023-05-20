

namespace Bus4All;

public partial class SelecionarPercurso : ContentPage
{
	public SelecionarPercurso()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Percurso Selecionado", "You have been alerted", "OK");
    }
}