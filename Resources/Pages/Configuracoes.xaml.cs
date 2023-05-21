namespace Bus4All;

public partial class Configuracoes : ContentPage
{
	public Configuracoes()
	{
		InitializeComponent();
	}
    private void Switch_Toggled(object sender, ToggledEventArgs e)
    { Switch switchControl = (Switch)sender;
        bool isOn = switchControl.IsToggled;

        if (isOn)
        {
            // Change the switch color to green
            switchControl.ThumbColor = Color.FromRgb(19, 192, 90);
            switchControl.OnColor = Color.FromRgb(19, 192, 90);

            // Perform actions for the "On" state
        }
        else
        {
            // Change the switch color to red
            switchControl.ThumbColor = Color.FromRgb(145, 12, 12);
            switchControl.OnColor = Color.FromRgb(145, 12, 12);

            // Perform actions for the "Off" state
        }
    }
    private void switchButtonn_Toggled(object sender, ToggledEventArgs e)
    {
        Switch switchControl = (Switch)sender;
        bool isOn = switchControl.IsToggled;

        if (isOn)
        {
            // Change the switch color to green
            switchControl.ThumbColor = Color.FromRgb(19, 192, 90);
            switchControl.OnColor = Color.FromRgb(19, 192, 90);

            // Perform actions for the "On" state
        }
        else
        {
            // Change the switch color to red
            switchControl.ThumbColor = Color.FromRgb(145, 12, 12);
            switchControl.OnColor = Color.FromRgb(255, 0, 0);

            // Perform actions for the "Off" state
        }
    }


}