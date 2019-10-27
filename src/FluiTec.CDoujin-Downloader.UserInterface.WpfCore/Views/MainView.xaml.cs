using System.Windows;
using FluiTec.CDoujin_Downloader.UserInterface.WpfCore.ViewModels;

namespace FluiTec.CDoujin_Downloader.UserInterface.WpfCore.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView(MainViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
