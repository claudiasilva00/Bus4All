

namespace Bus4All;

public partial class Selecionarfav : ContentPage
{
    private List<string> paragemList;

    public bool fav= true;

    public Selecionarfav()
	{
		InitializeComponent();

        paragemList = new List<string>
        {
            "UTAD REITORIA",
            "UTAD ENGENHARIAS",
            "UTAD PEDAGÓGICO",
            "UTAD LIVRARIA",
            "PRAÇA GALIZA",
            "AV.UNIVERSIDADE",
            "CARREIRA LONGA ",
            "R. AUGUSTO CÉSAR",
            "R. MANUEL SANTOS",
            "ESCOLAS ARAUCÁRIA",
            "IGREJA STº ANTÓNIO",
            "C. SAÚDE MATEUS ",
            "R. GASPAR SAMEIRO (2)",
            "R. GASPAR SAMEIRO (1)",
            "MATEUS         ",
            "Bº DO ALEM     ",
            "ABAMBRES       ",
            "COOPERATIVA    ",
            "LUGAR DO BOQUE ",
            "Bº STªA MARIA  ",
            "RIO CORGO      ",
            "CURVA DA Timpeira",
            "PR. 25 DE ABRIL",
            "CEMITÉRIO      ",
        };

        pembarquePicker.ItemsSource = paragemList;
        pdesembarquePicker.ItemsSource = paragemList;

        if(fav) {
            pembarquePicker.SelectedItem = "UTAD ENGENHARIAS";
            pdesembarquePicker.SelectedItem = "ESCOLAS ARAUCÁRIA";
        }

    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        string selectedPembarque = pembarquePicker.SelectedItem as string;
        string selectedPdesembarque = pdesembarquePicker.SelectedItem as string;

        var result = await DisplayAlert("PERCURSO SELECIONADO", $"Embarque: {selectedPembarque}\n\nDesembarque: {selectedPdesembarque}", "CONFIRMAR", "CANCELAR");

        if (result)
        {
            await Shell.Current.GoToAsync("..");
            await Shell.Current.GoToAsync("map");
        }
    }
}