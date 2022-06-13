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
            LbxFrom.Visibility = Visibility.Hidden;
            LbxTo.Visibility = Visibility.Hidden;
        }

        private void FromStation_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                LbxFrom.SelectedIndex = 0;
                LbxFrom.Focus();
            }
        }

        private void FromStation_GotFocus(object sender, RoutedEventArgs e)
        {
            LbxFrom.Visibility = Visibility.Visible;
        }
        private void FromStation_LostFocus(object sender, RoutedEventArgs e)
        {
            LbxFrom.Visibility = Visibility.Hidden;
        }
        private void LbxFrom_GotFocus(object sender, RoutedEventArgs e)
        {
            LbxFrom.Visibility = Visibility.Visible;
        }

        private void LbxFrom_LostFocus(object sender, RoutedEventArgs e)
        {
            LbxFrom.Visibility = Visibility.Hidden;
        }
        private void LbxFrom_Click(object sender, MouseButtonEventArgs e)
        {
            if(LbxFrom.SelectedValue != null)
            {
                TbxFrom.Text = LbxFrom.SelectedValue.ToString();
                LbxFrom.Visibility = Visibility.Hidden;
            }
            
        }

        private void LbxFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TbxFrom.Text = LbxFrom.SelectedValue.ToString();
                LbxFrom.Visibility = Visibility.Hidden;
            }
        }

        private void LbxTo_Click(object sender, MouseButtonEventArgs e)
        {
            if(LbxTo.SelectedValue != null)
            {
                TbxTo.Text = LbxTo.SelectedValue.ToString();
                LbxTo.Visibility = Visibility.Hidden;
            }
            
        }

        private void LbxTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TbxTo.Text = LbxTo.SelectedValue.ToString();
                LbxTo.Visibility = Visibility.Hidden;
            }
        }


        private void ToStation_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                LbxTo.SelectedIndex = 0;
                LbxTo.Focus();
            }
        }

        private void ToStation_GotFocus(object sender, RoutedEventArgs e)
        {
            LbxTo.Visibility = Visibility.Visible;
        }

        private void ToStation_LostFocus(object sender, RoutedEventArgs e)
        {
            LbxTo.Visibility = Visibility.Hidden;
        }

        private void LbxTo_LostFocus(object sender, RoutedEventArgs e)
        {
            LbxTo.Visibility = Visibility.Hidden;
        }

        private void LbxTo_GotFocus(object sender, RoutedEventArgs e)
        {
            LbxTo.Visibility = Visibility.Visible;
        }
    }
}
