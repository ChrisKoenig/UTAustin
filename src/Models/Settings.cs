using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace UTAustin
{
    public class Settings : ModelBase
    {
        #region Constructor

        public Settings()
        {
            Locations = new ObservableCollection<Location>();
        }

        #endregion

        #region Properties

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value) return;
                name = value;
                RaisePropertyChanged("Name");
            }
        }

        public string NameToUpper
        {
            get { return name.ToUpper(); }
        }
        
        public string NewsUrl { get; set; }

        private string bingMapsKey;
        public string BingMapsKey
        {
            get { return bingMapsKey; }
            set
            {
                if (bingMapsKey == value) return;
                bingMapsKey = value;
                RaisePropertyChanged("BingMapsKey");
            }
        }

        public ObservableCollection<Location> Locations { get; set; }

        private SolidColorBrush themeColor1;
        public SolidColorBrush ThemeColor1
        {
            get { return themeColor1; }
            set
            {
                if (themeColor1 == value) return;
                themeColor1 = value;
                RaisePropertyChanged("ThemeColor1");
            }
        }

        private SolidColorBrush themeColor2;
        public SolidColorBrush ThemeColor2
        {
            get { return themeColor2; }
            set
            {
                if (themeColor2 == value) return;
                themeColor2 = value;
                RaisePropertyChanged("ThemeColor2");
            }
        }

        #endregion

        #region Public Methods

        public string GetBingStaticMapUrl()
        {
            if (Locations.Count > 0)
            {
                return string.Format("http://dev.virtualearth.net/REST/v1/Imagery/Map/Road/{0},{1}/15?mapSize=376,376&pp={0},{1};21&mapVersion=v1&key={2}", Locations[0].Latitude, Locations[0].Longitude, BingMapsKey);
            }
            else
            {
                return string.Empty;
            }            
        }

        #endregion
    }
}
