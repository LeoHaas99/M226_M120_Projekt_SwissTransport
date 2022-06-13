using System;
using System.Collections.Generic;
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

namespace M226_M120_Projekt_SwissTransport.Views
{
    /// <summary>
    /// Interaktionslogik für StationboardView.xaml
    /// </summary>
    public partial class StationboardView : UserControl
    {
        public StationboardView()
        {
            InitializeComponent();
        }
        private void mapView_Loaded(object sender, RoutedEventArgs e)
        {
            // standard map configuration

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            // choose your provider here
            mapView.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            mapView.MinZoom = 2;
            mapView.MaxZoom = 17;
            // whole world zoom
            mapView.Zoom = 2;
            // lets the map use the mousewheel to zoom
            mapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            // lets the user drag the map
            mapView.CanDragMap = true;
            // lets the user drag the map with the left mouse button
            mapView.DragButton = MouseButton.Left;
        }

        private void ViewLoaded(object sender, RoutedEventArgs e)
        {
            LbxStation.Visibility = Visibility.Hidden;
        }

        private void TbxStation_GotFocus(object sender, RoutedEventArgs e)
        {
            LbxStation.Visibility = Visibility.Visible;
        }

        private void TbxStation_LostFocus(object sender, RoutedEventArgs e)
        {
            LbxStation.Visibility = Visibility.Hidden;
        }

        private void LbxStation_LostFocus(object sender, RoutedEventArgs e)
        {
            LbxStation.Visibility = Visibility.Hidden;
        }

        private void LbxStation_GotFocus(object sender, RoutedEventArgs e)
        {
            LbxStation.Visibility = Visibility.Visible;
        }

        private void LbxStation_Click(object sender, MouseButtonEventArgs e)
        {
            if (LbxStation.SelectedValue != null)
            {
                TbxStation.Text = LbxStation.SelectedValue.ToString();
                LbxStation.Visibility = Visibility.Hidden;
            }
        }
    }
}
