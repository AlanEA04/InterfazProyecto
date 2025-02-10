namespace InterfazProyecto
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Registro de rutas
            Routing.RegisterRoute(nameof(Incio), typeof(Incio));
            Routing.RegisterRoute(nameof(Temporisador), typeof(Temporisador));
        }

    }
}
