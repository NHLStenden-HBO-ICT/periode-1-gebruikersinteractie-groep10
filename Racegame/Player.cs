/// <summary>

/// </summary>
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System;
using Racegame;
using System.Diagnostics;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows;

public class Player
{   // player properties //
    public double X;
    public double Y;
    public string Name;
    public double Angle = 50;
    private double maxSpeed = 5;

    private double Speed = 0;
    private int RotateSpeed = 3;

    public Key[] KeyControls; // Key controls for left, forward, and right movements. //
    public bool[] KeyDown = { false, false, false }; // Store directions as boolean values (left, forward, right). //
    public Rectangle Element = new Rectangle(); // Create rectangle to serve as a base element for the player. //
    public Image Img = new Image();
    public Player(Canvas canvas, string playerName, Key[] keyControls, double x = 0, double y = 0)
    {
        X = x;
        Y = y;
        Name = playerName;
        KeyControls = keyControls;

        int rectHeight = 20; // Set the properties of the player's graphical element //
        int rectWidth = 40;

        Img.Height = rectHeight * 2;
        Img.Width = rectWidth;
        Img.Source = new BitmapImage(new Uri("pack://application:,,,/Racegame;component/car.png\r\n"));
        Img.Stretch = Stretch.Fill;

        Element.Height = rectHeight;
        Element.Width = rectWidth;
        Element.Stroke = Brushes.Black; Element.StrokeThickness = 1;

        canvas.Children.Add(Img);
        canvas.Children.Add(Element); // Add the player's graphical element to the canvas //

    }
    private void PolarConversion(double inputAngle, double speed)
    {   // Calculate new X and Y coordinates based on the input angle and speed/distance //
        double AngleInRadians = inputAngle * (Math.PI / 180.0);
        double directionX = speed * Math.Cos(AngleInRadians);
        double directionY = speed * Math.Sin(AngleInRadians);
        X += directionX;
        Y += directionY;
    }
    private void Accelerate()
    {
        if (Speed <= maxSpeed) Speed += maxSpeed * 0.01;
        PolarConversion(Angle, Speed);
    }
    private void Decelerate()
    {
        if (Speed > 0)
        {
            Speed *= 0.95;
            PolarConversion(Angle, Speed);
        }
    }
    public void Control()
    {   // Handle key inputs to control the player //
        if (KeyDown[0] == true) Angle -= RotateSpeed; // Rotate left //
        if (KeyDown[1] == true) { Accelerate(); } else { Decelerate(); }
        if (KeyDown[2] == true) Angle += RotateSpeed; // Rotate right //
        if (Angle >= 360 || Angle <= -360) Angle = 0; // Ensure the angle stays within bounds //
    }
}