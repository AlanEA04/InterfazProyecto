namespace InterfazProyecto;

public partial class Temporisador : ContentPage
{
    public Temporisador()
    {
        InitializeComponent();
    }

    private void OnMenuClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true; // Abre el menú lateral
    }
}
