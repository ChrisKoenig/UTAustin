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
    public class Link : ModelBase
    {
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) return;
                title = value;
                RaisePropertyChanged("Title");
            }
        }

        private string url;
        public string Url
        {
            get { return url; }
            set
            {
                if (url == value) return;
                url = value;
                RaisePropertyChanged("Url");
            }
        }

        public bool IsRss { get; set; }

        public Link()
        {
        }
    }
}
