using Bus4All;

namespace Bus4All;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("MainPage",typeof(MainPage));
        Routing.RegisterRoute("seta",typeof(Horarios));
        Routing.RegisterRoute("bus",typeof(Paragens));
        Routing.RegisterRoute("selec",typeof(SelecionarPercurso));
        Routing.RegisterRoute("euro",typeof(Tarifas));
        Routing.RegisterRoute("map",typeof(Mapa));
        Routing.RegisterRoute("config", typeof(Configuracoes));
        Routing.RegisterRoute("fav", typeof(Selecionarfav));
    }

    private void ShellContent_Appearing(object sender,EventArgs e) {
        //home.ContentTemplate = new DataTemplate(() => new MainPage());
        //fav.ContentTemplate = new DataTemplate(() => new MainPage());
    }

    private void set_fav(object sender,EventArgs e) {
        //((SelecionarPercurso)sender).fav = true;
    }
}
