namespace InterfazProyecto;

public partial class Historial : ContentPage
{
    public Historial()
    {
        InitializeComponent();

        // Datos de ejemplo
        var historialData = new List<HistorialItem>
        {
            new HistorialItem { Dia = "01/01/2025", Litros = "10", Tiempo = "0130" },
            new HistorialItem { Dia = "01/01/2025", Litros = "9", Tiempo = "0045" },
            new HistorialItem { Dia = "01/01/2025", Litros = "23", Tiempo = "0333" },
            new HistorialItem { Dia = "01/01/2025", Litros = "5", Tiempo = "0156" },
            new HistorialItem { Dia = "01/01/2025", Litros = "7", Tiempo = "0253" },
            new HistorialItem { Dia = "01/01/2025", Litros = "11", Tiempo = "0538" },
            new HistorialItem { Dia = "01/01/2025", Litros = "2", Tiempo = "0140" }
        };

        // Asignar los datos al ListView
        HistorialListView.ItemsSource = historialData;
    }

    // Método para abrir el menú cuando se presiona el botón ☰
    private void OnMenuClicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true; // Abre el menú lateral
    }
}

public class HistorialItem
{
    public string Dia { get; set; }
    public string Litros { get; set; }
    public string Tiempo { get; set; }
}