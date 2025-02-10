namespace InterfazProyecto;

public partial class Incio : ContentPage
{
    public Incio()
    {
        InitializeComponent();
    }

    // Método para abrir el menú cuando se presiona el botón ☰
    private void OnMenuClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true; // Abre el menú lateral
    }
}
