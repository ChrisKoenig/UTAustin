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

namespace UTAustin
{
    public class Forecast : ModelBase
    {
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

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date == value) return;
                date = value;
                RaisePropertyChanged("Date");
            }
        }

        private int temperature;
        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (temperature == value) return;
                temperature = value;
                RaisePropertyChanged("Temperature");
            }
        }

        private string conditions;
        public string Conditions
        {
            get { return conditions; }
            set
            {
                if (conditions == value) return;
                conditions = value;
                RaisePropertyChanged("Conditions");
            }
        }

        private string imageUrl;
        public string ImageUrl
        {
            get { return imageUrl; }
            set
            {
                if (imageUrl == value) return;
                imageUrl = value;
                RaisePropertyChanged("ImageUrl");
            }
        }

        public string TempAndConditions
        {
            get { return string.Format("{0} and {1}", Temperature, Conditions); }
        }

        public string DateText
        {
            get { return Date.ToString("m"); }
        }
    }
}
