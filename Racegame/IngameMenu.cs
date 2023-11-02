using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Racegame
{
    internal class IngameMenu
    {
        private Canvas Canvas;
        private Rectangle background;
        private Button resumeButton;
        private Button quitButton;

        public IngameMenu(Canvas canvas)
        {
            this.Canvas = canvas;

            ResourceDictionary resourceDict = new ResourceDictionary();
            resourceDict.Source = new Uri("Styles.xaml", UriKind.Relative);
            

            background = new Rectangle
            {
                Width = 1920,
                Height = 2080,
                Fill = new SolidColorBrush(Colors.Black),
                Visibility = System.Windows.Visibility.Collapsed, // Initially hide the background
                Opacity = 0.7
            };

            quitButton = new Button
            {
                Content = "Spel afsluiten",
                Width = 500,
                Height = 150,
                Visibility = System.Windows.Visibility.Collapsed, // Initially hide the button
                Style = (Style)resourceDict["ButtonStyle"],
        };
            quitButton.Click += (s, e) => {Window.GetWindow(canvas).Close();}; // quit button functionality
            // Add background and buttons to the Canvas
            canvas.Children.Add(background);
            canvas.Children.Add(quitButton);
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            // Show the background and buttons
            background.Visibility = System.Windows.Visibility.Visible;
            quitButton.Visibility = System.Windows.Visibility.Visible;

            // Set the position to center the button horizontally and vertically
            Canvas.SetLeft(quitButton, (Canvas.ActualWidth - quitButton.Width) / 2);
            Canvas.SetTop(quitButton, (Canvas.ActualHeight - quitButton.Height) / 2);
        }

        public void Hide()
        {
            // Hide the background and buttons
            background.Visibility = System.Windows.Visibility.Collapsed;
            quitButton.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
