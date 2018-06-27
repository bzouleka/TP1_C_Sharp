using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibMetro;
using Microsoft.Maps.MapControl.WPF;

namespace MetroWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object line;

        public MainWindow()
        {
            InitializeComponent();

            /*this.Title = "Metro Mobilité";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;*/
            carte.Focus();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var Lat = latitude.Text;
            var Lon = longitude.Text;
            var Rayon = rayon.Text;

           
            MetroLib metro = new MetroLib();

            List<Lines> listSansDoublon = MetroLib.BusStopProxity(Lon, Lat, Rayon);

            foreach (Lines line in listSansDoublon) // iteration ligne par ligne 
            {
                Console.WriteLine($"Nom de la ligne {line.name}");

                Pushpin pin = new Pushpin();

                //Conversion des strings latitude et longitude en double
                double c_latitude = Convert.ToDouble(line.lat, new CultureInfo("en-GB"));
                double c_longitude = Convert.ToDouble(line.lon, new CultureInfo("en-GB"));
                
                //Connexion des pin à la location
                pin.Location = new Location(c_latitude, c_longitude);
               
                carte.Children.Add(pin);

            }
            busStop.ItemsSource = listSansDoublon;
            Console.ReadLine();

        
        }

        
    }
}
