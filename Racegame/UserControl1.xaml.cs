using System.Windows;
using System.Windows.Controls;

namespace Racegame
{
    public partial class UserControl1 : UserControl
    {
        private MainWindow mainWindow;

        public UserControl1()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.clearMain();
                mainWindow.Content = new CircuitSelection();
            }
        }
    }
}
