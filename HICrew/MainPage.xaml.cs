using System.Windows.Input;

namespace HICrew
{
    public partial class MainPage
    {
        private async void NavigateSignup(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
