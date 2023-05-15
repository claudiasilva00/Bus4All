using Bus4All.Resources.Pages;
namespace Bus4All;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("seta",typeof(Horarios));
        Routing.RegisterRoute("bus",typeof(Paragens));
        Routing.RegisterRoute("sinais",typeof(SelecionarPercurso));
        Routing.RegisterRoute("euro",typeof(Tarifas));
        Routing.RegisterRoute("map",typeof(Mapa));
    }
}
