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
using static System.Net.Mime.MediaTypeNames;

namespace Racegame
{
    /// <summary>
    /// Interaction logic for CircuitSelection.xaml
    /// </summary>
    public partial class CircuitSelection : Page
    {
        private string[] imagePaths;
        private int currentIndex = 0;

        public CircuitSelection()
        {
            InitializeComponent();
            imagePaths = new string[] { "Images/GoodOlClassic.png", "Images/SillySlope.png", "Images/SpagettiTime.png" };
            UpdateImages();
        }

        private void UpdateImages()
        {
            if (imagePaths != null && imagePaths.Length >= 3)
            {
                // Load the current image and the two adjacent images
                BitmapImage currentImage = new BitmapImage(new Uri(imagePaths[currentIndex], UriKind.RelativeOrAbsolute));
                BitmapImage nextImage = new BitmapImage(new Uri(imagePaths[(currentIndex + 1) % imagePaths.Length], UriKind.RelativeOrAbsolute));
                BitmapImage prevImage = new BitmapImage(new Uri(imagePaths[(currentIndex + 2) % imagePaths.Length], UriKind.RelativeOrAbsolute));

                image1.Source = currentImage;
                image2.Source = nextImage;
                image3.Source = prevImage;
            }
        }

        private void PreviousImage_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Length;
            UpdateImages();
        }

        private void NextImage_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Length) % imagePaths.Length;
            UpdateImages();
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            Gamescreen GameWindow = new Gamescreen();       
            GameWindow.Show();
        }

        private void Return(object sender, RoutedEventArgs e)
        {
            
            MainWindow newMainWindow = new MainWindow();

            
            Window thisWindow = Window.GetWindow(this);
            thisWindow.Content = newMainWindow.Content;
            newMainWindow.fadingLogo.Visibility = Visibility.Hidden;
        }
    }
}