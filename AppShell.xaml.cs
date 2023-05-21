using Bus4All.Resources.Pages;

namespace Bus4All;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("MainPage",typeof(MainPage));
        Routing.RegisterRoute("seta",typeof(Horarios));
        Routing.RegisterRoute("bus",typeof(Paragens));
        Routing.RegisterRoute("sinais",typeof(SelecionarPercurso));
        Routing.RegisterRoute("euro",typeof(Tarifas));
        Routing.RegisterRoute("map",typeof(Mapa));
        Routing.RegisterRoute("config", typeof(Configuracoes));
    }

    private void ShellContent_Appearing(object sender,EventArgs e) {
        home.ContentTemplate = new DataTemplate(() => new MainPage());
        fav.ContentTemplate = new DataTemplate(() => new MainPage());
    }
}
