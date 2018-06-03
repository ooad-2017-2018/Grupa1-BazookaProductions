﻿using System;
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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPanel : Page
    {
        PanelViewModel PWM;
        public AdminPanel()
        {
            this.InitializeComponent();
            PWM = new PanelViewModel();
            PWM.popuniKorisnike();
            for(int i=0;i<Models.SarajevoTravel.korisnici.Count;i++)
            {
                string s;
                s = Models.SarajevoTravel.korisnici[i].Ime + " " + Models.SarajevoTravel.korisnici[i].Prezime;
                comboBox1.Items.Add(s);
            }
        }
        private void obrisiObjekatButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void obrisiKomentarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void obrisiKorisnikaButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
