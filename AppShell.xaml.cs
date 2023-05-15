namespace Bus4All;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("about",typeof(NewPage1));
    }
}
