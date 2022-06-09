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
    /// Interaktionslogik für ConnectionsView.xaml
    /// </summary>
    public partial class ConnectionsView : UserControl
    {
        public ConnectionsView()
        {
            InitializeComponent();
        }

        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            LbFrom.Visibility = Visibility.Hidden;
            LbTo.Visibility = Visibility.Hidden;
        }
        private void FromStation_GotFocus(object sender, RoutedEventArgs e)
        {
            LbFrom.Visibility = Visibility.Visible;
        }
        private void FromStation_LostFocus(object sender, RoutedEventArgs e)
        {
            LbFrom.Visibility = Visibility.Hidden;
        }
        private void LbFrom_GotFocus(object sender, RoutedEventArgs e)
        {
            LbFrom.Visibility = Visibility.Visible;
        }

        private void LbFrom_LostFocus(object sender, RoutedEventArgs e)
        {
            LbFrom.Visibility = Visibility.Hidden;
        }
        private void LbFrom_Click(object sender, MouseButtonEventArgs e)
        {
            if(LbFrom.SelectedValue != null)
            {
                TbxFrom.Text = LbFrom.SelectedValue.ToString();
                LbFrom.Visibility = Visibility.Hidden;
            }
            
        }
        private void LbTo_Click(object sender, MouseButtonEventArgs e)
        {
            if(LbTo.SelectedValue != null)
            {
                TbxTo.Text = LbTo.SelectedValue.ToString();
                LbTo.Visibility = Visibility.Hidden;
            }
            
        }

        private void ToStation_GotFocus(object sender, RoutedEventArgs e)
        {
            LbTo.Visibility = Visibility.Visible;
        }

        private void ToStation_LostFocus(object sender, RoutedEventArgs e)
        {
            LbTo.Visibility = Visibility.Hidden;
        }

        private void LbTo_LostFocus(object sender, RoutedEventArgs e)
        {
            LbTo.Visibility = Visibility.Hidden;
        }

        private void LbTo_GotFocus(object sender, RoutedEventArgs e)
        {
            LbTo.Visibility = Visibility.Visible;
        }
    }
}
