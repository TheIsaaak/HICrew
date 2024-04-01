using System.Windows.Input;

namespace HICrew
{
    public partial class MainPage : ContentPage
    {

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));


        public MainPage()
        {
            InitializeComponent();
        }
    }
}
