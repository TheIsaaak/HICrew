namespace HICrew
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Signup), typeof(Signup));
        }
    }
}
