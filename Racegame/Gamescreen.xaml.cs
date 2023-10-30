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
using System.Windows.Shapes;

namespace Racegame
{
    /// <summary>
    /// Interaction logic for Gamescreen.xaml
    /// </summary>
    public partial class Gamescreen : Window
    {
        GameEngine engine;
        public Gamescreen()
        {
            InitializeComponent();
            engine = new GameEngine(canvasElement);
            canvasElement.Children.Clear();

            engine.AddPlayer("test", new Key[] { Key.A, Key.W, Key.D }, 10, 10);
            engine.AddPlayer("test", new Key[] { Key.Left, Key.Up, Key.Right }, 10, 10);
            engine.Start();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        { // pass onKeyDown event to GameEngine 
            engine.keyHandler(sender, e, true);
        }
        private void OnKeyUp(object sender, KeyEventArgs e)
        { // pass onKeyUp event to GameEngine 
            engine.keyHandler(sender, e, false);
        }
    }
}