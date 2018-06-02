using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SarajevoTravel1._0
{

    public sealed partial class MainPage : Page
    {
        LoginViewModel LWM;

        public MainPage()
        {
            this.InitializeComponent();
            LWM = new LoginViewModel();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            int t;
            t = LWM.DajTipLogina(usernameTextBox.Text.ToString(), passwordBox.ToString());
            if (t == 1)
            {
                // obicni korisnik
            }
            if (t == 2)
            {
                // vlasnik objekta
            }
            if (t == 3)
            {
                // admin
                Frame.Navigate(typeof(AdminPanel));// nece da nadje ovo BlankPage1
            }
            if (t == 4)
            {
                // greska
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Registracija));
        }
    }
}
