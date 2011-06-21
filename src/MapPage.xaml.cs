using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;
using System.Device.Location;
using Microsoft.Phone.Controls.Maps;

namespace UTAustin
{
    public partial class MapPage : PhoneApplicationPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            DataContext = App.ViewModel;

            setupMap();
        }

        private void setupMap()
        {
            if (App.ViewModel.Settings.Locations.Count > 0)
            {
                //set the Bing maps key
                map.CredentialsProvider = new ApplicationIdCredentialsProvider(App.ViewModel.Settings.BingMapsKey);

                // Set the center coordinate and zoom level
                GeoCoordinate mapCenter = new GeoCoordinate(App.ViewModel.Settings.Locations[0].Latitude, App.ViewModel.Settings.Locations[0].Longitude);
                int zoom = 15;

                // create a pushpins for each location
                Pushpin pin = null;
                for (int i = 0; i < App.ViewModel.Settings.Locations.Count; i++)
                {
                    pin = new Pushpin();
                    pin.Location = new GeoCoordinate(App.ViewModel.Settings.Locations[i].Latitude, App.ViewModel.Settings.Locations[i].Longitude);
                    pin.Content = App.ViewModel.Settings.Locations[i].Title;
                    map.Children.Add(pin);   
                }

                // Set the map style to Aerial
                map.Mode = new RoadMode();

                // Set the view and put the map on the page
                map.SetView(mapCenter, zoom);
            }
            else
            {
                //notify user
            }
        }
    }
}