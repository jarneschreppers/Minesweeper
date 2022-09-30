using System.Windows;
using ViewModel.Screen;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            this.DataContext = new MainViewModel();
        }
    }
}
