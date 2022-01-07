using System;
using System.Windows;
using System.Windows.Controls;
using WorldMap.Module;
using WorldMap.Module.Data;

namespace WorldMap.Views
{
    /// <summary>
    /// DefaultGeoMapTooltip.xaml 的交互逻辑
    /// </summary>
    public partial class DefaultGeoMapTooltip : UserControl
    {
        public DefaultGeoMapTooltip()
        {
            InitializeComponent();

            SetCurrentValue(CornerRadiusProperty, 4d);

            DataContext = this;
        }

        /// <summary>
        /// The corner radius property
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius", typeof(double), typeof(DefaultGeoMapTooltip), new PropertyMetadata(default(double)));

        /// <summary>
        /// Gets or sets the corner radius.
        /// </summary>
        /// <value>
        /// The corner radius.
        /// </value>
        public double CornerRadius
        {
            get => (double)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        /// <summary>
        /// The label formatter property
        /// </summary>
        public static readonly DependencyProperty LabelFormatterProperty = DependencyProperty.Register(
            "LabelFormatter", typeof(Func<double, string>), typeof(DefaultGeoMapTooltip), new PropertyMetadata(default(Func<double, string>)));

        /// <summary>
        /// Gets or sets the label formatter.
        /// </summary>
        /// <value>
        /// The label formatter.
        /// </value>
        public Func<double, string> LabelFormatter
        {
            get => (Func<double, string>)GetValue(LabelFormatterProperty);
            set => SetValue(LabelFormatterProperty, value);
        }

        /// <summary>
        /// The geo data property
        /// </summary>
        public static readonly DependencyProperty GeoDataProperty = DependencyProperty.Register(
            "GeoData", typeof(GeoData), typeof(DefaultGeoMapTooltip), new PropertyMetadata(default(GeoData)));

        /// <summary>
        /// Gets or sets the geo data.
        /// </summary>
        /// <value>
        /// The geo data.
        /// </value>
        public GeoData GeoData
        {
            get => (GeoData)GetValue(GeoDataProperty);
            set => SetValue(GeoDataProperty, value);
        }

    }
}
