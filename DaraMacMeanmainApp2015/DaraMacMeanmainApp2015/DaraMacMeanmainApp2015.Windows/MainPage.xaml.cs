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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DaraMacMeanmainApp2015
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

       private void osirisButton_Click(object sender, RoutedEventArgs e)
       {
           Frame.Navigate(typeof(osirisPage), UriKind.Relative);
       }

        private void blueTeamButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(blueTeamPage), UriKind.Relative);
        }

        private void glassedButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(glassedPage), UriKind.Relative);
        }

        private void meridianStationButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(meridianStationPage), UriKind.Relative);
        }

        private void unconfirmedButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(unconfirmedPage), UriKind.Relative);
        }

        private void evacuationButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(evacuationPage), UriKind.Relative);
        }

        private void reunionButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(reunionPage), UriKind.Relative);
        }

        private void swordsOfSangeliosButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(swordsOfSangheliosPage), UriKind.Relative);
        }

        private void allianceButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(alliancePage), UriKind.Relative);
        }

        private void enemyLinesButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(enemyLinesPage), UriKind.Relative);
        }

        private void beforeTheStormButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(beforeTheStormPage), UriKind.Relative);
        }

        private void battleOfSunaionButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(battleOfSunaionPage), UriKind.Relative);
        }

        private void genesisButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(genesisPage), UriKind.Relative);
        }

        private void theBreakingButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(theBreakingPage), UriKind.Relative);
        }

        private void guardiansButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(guardiansPage), UriKind.Relative);
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
