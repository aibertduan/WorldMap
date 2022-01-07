using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldMap.Views
{
    /// <summary>
    /// GeoMapExample.xaml 的交互逻辑
    /// </summary>
    public partial class GeoMapExample : UserControl
    {
        public GeoMapExample()
        {
            InitializeComponent();

            var r = new Random();

            Values = new Dictionary<string, double>
            {
                ["MX"] = r.Next(0, 100),
                ["CA"] = r.Next(0, 100),
                ["US"] = r.Next(0, 100),
                ["IN"] = r.Next(0, 100),
                ["CN"] = r.Next(0, 100),
                ["JP"] = r.Next(0, 100),
                ["BR"] = r.Next(0, 100),
                ["DE"] = r.Next(0, 100),
                ["FR"] = r.Next(0, 100),
                ["GB"] = r.Next(0, 100)
            };


            LanguagePack = new Dictionary<string, string>();
            LanguagePack["MX"] = "México"; // change the language if necessary

            Map.HeatMap = Values;

            DataContext = this;
        }

        public Dictionary<string, double> Values { get; set; }
        public Dictionary<string, string> LanguagePack { get; set; }
    }
}
