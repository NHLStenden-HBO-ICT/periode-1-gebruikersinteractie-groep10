using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IngameMenu(Canvas canvas) {

            background = new Rectangle
            {
                Width = 800,  // Adjust width and height as needed
                Height = 600,
                Fill = new SolidColorBrush(Colors.Black),  // Set the background color
            };

            // Create menu buttons
            resumeButton = new Button
            {
                Content = "Resume Game",
                Width = 200,  // Set button size
                Height = 50,
            };

            quitButton = new Button
            {
                Content = "Quit Game",
                Width = 200,
                Height = 50,
            };

            // Add background and buttons to the Grid
            canvas.Children.Add(background);
            canvas.Children.Add(resumeButton);
            canvas.Children.Add(quitButton);
            
            // Set the position to center the button horizontally and vertically
            Canvas.SetLeft(resumeButton, (canvas.ActualWidth - resumeButton.Width) / 2);
            Canvas.SetTop(resumeButton, (canvas.ActualHeight - resumeButton.Height) / 2);

            // Set the position to center the button horizontally and vertically
            Canvas.SetLeft(quitButton, (canvas.ActualWidth - quitButton.Width) / 2);
            Canvas.SetTop(quitButton, (canvas.ActualHeight - quitButton.Height) / 2);        }

        public void Show()
        {
            // Show the background and buttons
            background.Visibility = System.Windows.Visibility.Visible;
            resumeButton.Visibility = System.Windows.Visibility.Visible;
            quitButton.Visibility = System.Windows.Visibility.Visible;
        }

        public void Hide()
        {
            // Hide the background and buttons
            background.Visibility = System.Windows.Visibility.Collapsed;
            resumeButton.Visibility = System.Windows.Visibility.Collapsed;
            quitButton.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
