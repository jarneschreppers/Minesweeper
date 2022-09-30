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

namespace View.Screen
{
    /// <summary>
    /// Interaction logic for SettingsScreen.xaml
    /// </summary>
    public partial class SettingsScreen : UserControl
    {
        public SettingsScreen()
        {
            InitializeComponent();
        }
        private void SetLightMode(object sender, RoutedEventArgs e)
        {
            SetTheme("Light");
        }

        private void SetDarkMode(object sender, RoutedEventArgs e)
        {
            SetTheme("Dark");
        }

        private void SetTheme(string name)
        {
            var app = (App)Application.Current;
            app.SetTheme(name);
        }
    }
}
