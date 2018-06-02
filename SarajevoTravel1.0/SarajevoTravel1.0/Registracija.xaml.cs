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
        int i = 0;
        RegistracijaViewModel RWM;
        public Registracija()
        {
            this.InitializeComponent();
            RWM = new RegistracijaViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
    
            // Fali checkbox za vlasnika, stavi ovdje iz kojih textboxa uzima text :
            bool uspio = false;
            if(i!=0)
            uspio= RWM.uspjesnaRegistracija(textBox_Ime.Text, textBox_Prezime.Text, textBox_Username.Text, textBox_Password.Password, textBox_Email.Text,i);
            // tipKorisnika 1 je za obicnog korisnika, 2 je za vlasnika

            // ako je uspio true, registrovao se, ako nije true, nesto ne valja

            if (uspio) Frame.Navigate(typeof(MainPage)); //ni ovo Login ne moze naci
        }

        private void klijent_Checked(object sender, RoutedEventArgs e)
        {
            i = 1;
        }

        private void vlasnik_Checked(object sender, RoutedEventArgs e)
        {
            i = 2;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
