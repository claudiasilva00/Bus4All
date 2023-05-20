

namespace Bus4All;

public partial class SelecionarPercurso : ContentPage
{
	public SelecionarPercurso()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string embarqueText = pembarque.Text;
        string desembarqueText = pdesembarque.Text;

        string message = $"Embarque: {embarqueText}\nDesembarque: {desembarqueText}";

        DisplayAlert("PERCURSO SELECIONADO", message, "CONFIRMAR", "CANCELAR");

    }
}