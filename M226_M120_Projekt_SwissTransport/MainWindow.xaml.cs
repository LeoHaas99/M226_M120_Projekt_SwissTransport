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

namespace M226_M120_Projekt_SwissTransport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectionsView_Loaded(object sender, RoutedEventArgs e)
        {
            M226_M120_Projekt_SwissTransport.ViewModels.ConnectionsViewModel ConnectionsViewModelObject =
            new M226_M120_Projekt_SwissTransport.ViewModels.ConnectionsViewModel();
            ConnectionsView.DataContext = ConnectionsViewModelObject;
        }
        private void StationboardView_Loaded(object sender, RoutedEventArgs e)
        {
            M226_M120_Projekt_SwissTransport.ViewModels.StationBoardViewModel StationBoardViewModelObject =
                 new M226_M120_Projekt_SwissTransport.ViewModels.StationBoardViewModel();
            StationboardView.DataContext = StationBoardViewModelObject;
        }
    }
}
