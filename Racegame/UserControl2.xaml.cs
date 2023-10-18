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

namespace Racegame
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        string[] descriptions = {
        "Beschrijving van het spel \n" +
        "placeholder 1",

        "placeholder 2",

        "placeholder 3"
        };

        int index = 0;
        public UserControl2()
        {
            InitializeComponent();
            DescriptionBox.Text = descriptions[index];
        }

        private void Left_Button_Click(object sender, RoutedEventArgs e)
        {
            if (index != 0) { index--; } else { index = descriptions.Length-1; }
            DescriptionBox.Text = descriptions[index];
        }

        private void Right_Button_Click(object sender, RoutedEventArgs e)
        {
            if (index != descriptions.Length-1) { index++; } else { index = 0; }
            DescriptionBox.Text = descriptions[index];
        }
    }
}
