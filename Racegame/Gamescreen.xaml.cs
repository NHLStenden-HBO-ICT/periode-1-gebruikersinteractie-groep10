using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
        private IngameMenu IngameMenu;

        public Gamescreen()
        {
            InitializeComponent();
            WindowStyle = WindowStyle.None;
            WindowState = WindowState.Maximized;
            engine = new GameEngine(canvasElement);

            engine.AddPlayer("test", new Key[] { Key.A, Key.W, Key.D }, 200, 125);
            engine.AddPlayer("test", new Key[] { Key.Left, Key.Up, Key.Right }, 200, 160);
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