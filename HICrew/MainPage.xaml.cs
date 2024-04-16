using System.Windows.Input;

namespace HICrew
{
    public partial class MainPage
    {
        private async void NavigateSignup(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }

        private async void NavigateForgotPassword(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
