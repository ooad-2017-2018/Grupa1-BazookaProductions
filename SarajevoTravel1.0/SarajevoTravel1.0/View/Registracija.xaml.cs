using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SarajevoTravel1._0
{
    public sealed partial class Registracija : Page
    {
        RegistracijaViewModel RWM;
        public Registracija()
        {
            this.InitializeComponent();
            RWM = new RegistracijaViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Fali checkbox za vlasnika, stavi ovdje iz kojih textboxa uzima text :
            //bool uspio = RWM.uspjesnaRegistracija(IME, PREZIME, USERNAME, PASSWORD, EMAIL, TIPKORISNIKA);
            // tipKorisnika 1 je za obicnog korisnika, 2 je za vlasnika

            // ako je uspio true, registrovao se, ako nije true, nesto ne valja

            //if (uspio) Frame.Navigate(typeof(Login)); ni ovo Login ne moze naci
        }
    }
}
