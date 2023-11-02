using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Racegame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create userpages
        Dictionary<string, UserControl> userControlDict = new Dictionary<string, UserControl>
        {
            { "page1", new UserControl1() },
            { "page2", new UserControl2() },
            { "page3", new UserControl3() },
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetPage(string key)
        {
            testFrame.Content = null;
            testFrame.NavigationService.RemoveBackEntry();

            UserControl userControl = userControlDict[key];
            userControl.Height = testFrame.ActualHeight;
            userControl.Width = testFrame.ActualWidth;
            testFrame.NavigationService.Navigate(userControl);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetPage("page1");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SetPage("page2");
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            SetPage("page3");
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void logoFadeCompleted(object sender, EventArgs e)
        {
            SetPage("page1");
        }
    }
}
