namespace HICrew
{
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license -- Ser ikke ut som den funke :(
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzIyMjU0OEAzMjM1MmUzMDJlMzBVTUVmWG5SWlJjc0VwY3FVRngyb1pwVjNRdXYxdmx2SkFURjlGRUpMRmdVPQ==");

            InitializeComponent();
            MainPage = new Microsoft.Maui.Controls.NavigationPage(new MainPage());
        }
    }
}
