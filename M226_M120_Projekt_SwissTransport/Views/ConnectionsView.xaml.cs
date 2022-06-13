using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace M226_M120_Projekt_SwissTransport.Views
{
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

        private void FromStation_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                LbFrom.SelectedIndex = 0;
                LbFrom.Focus();
            }
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

        private void LbFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
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

        private void LbTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TbxTo.Text = LbTo.SelectedValue.ToString();
                LbTo.Visibility = Visibility.Hidden;
            }
        }


        private void ToStation_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                LbTo.SelectedIndex = 0;
                LbTo.Focus();
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
