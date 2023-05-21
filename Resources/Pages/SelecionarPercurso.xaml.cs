

namespace Bus4All;

public partial class SelecionarPercurso : ContentPage
{
    private List<string> paragemList;

    public SelecionarPercurso()
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

    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        string selectedPembarque = pembarquePicker.SelectedItem as string;
        string selectedPdesembarque = pdesembarquePicker.SelectedItem as string;

        bool Bdisplay = true; 

        var result = await Application.Current.MainPage.DisplayAlert("PERCURSO SELECIONADO", $"Embarque: {selectedPembarque}\n\nDesembarque: {selectedPdesembarque}", "CONFIRMAR", "CANCELAR");

        if (result)
        {
            if (Bdisplay)
                await Shell.Current.GoToAsync("map");
            else
                await Shell.Current.GoToAsync("sinais");
        }


       
    }



}