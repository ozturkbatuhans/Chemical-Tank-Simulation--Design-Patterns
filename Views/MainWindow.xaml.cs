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
using Ozturk_Batuhan_PE2.ViewModels;

namespace Ozturk_Batuhan_PE2.Views
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            DataContext = viewModel;


        }

        private void btnOpvullen_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Vul();
        }

        private void btnSchoonmaken_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Schoonmaken();
        }

        private void btnOpenen_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Openen();
        }
    }
}