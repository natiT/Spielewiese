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
using MahApps.Metro;
using MahApps.Metro.Controls;

namespace Spielewiese
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleSwitch_IsCheckedChanged(object sender, EventArgs e)
        {
            if(Toogle_Theme.IsChecked == true)
            {
                ThemeManager.ChangeAppTheme(Application.Current, "BaseDark");
            }
            else
            {
                ThemeManager.ChangeAppTheme(Application.Current, "BaseLight");
            }
        }

        private void flyout_settings_IsOpenChanged(object sender, RoutedEventArgs e)
        {
            if(flyout_settings.IsOpen == true)
            {
                Console.WriteLine("Geöffnet");
            }
            else
            {
                Console.WriteLine("Geschlossen");
            }
            
        }
    }
}
