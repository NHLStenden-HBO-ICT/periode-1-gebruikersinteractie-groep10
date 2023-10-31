using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;

namespace Racegame
{
    internal class GameEngine
    {
        private Canvas Canvas; // The canvas where the game is drawn.
        private DispatcherTimer gameTimer; // Timer for game logic updates.
        private DispatcherTimer renderTimer; // Timer for rendering frames.
        private List<Player> playerList = new List<Player>(); // List to store player objects.
        private IngameMenu IngameMenu;
        private enum GameState { running, stopped, menu };
        private GameState currentState;
        public GameEngine(Canvas Canvas)
        {
            this.Canvas = Canvas;

            // Create and configure the game timer for game logic.
            gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromMilliseconds(16); // 60 frames per second (1000 ms / 16ms = ~60).
            gameTimer.Tick += onGameTick; // Specify the event handler method for game logic.

            // Create and configure the render timer for rendering frames.
            renderTimer = new DispatcherTimer();
            renderTimer.Interval = TimeSpan.FromMilliseconds(16); // 60 frames per second.
            renderTimer.Tick += onRenderTick; // Specify the event handler method for rendering. 

            /// Timer notice:
            /// The key is to ensure that the game logic timer and rendering timer remain synchronized, 
            /// meaning that the game logic updates before rendering. 
            /// As long as the rendering timer doesn't run too far ahead of the game logic timer,
            /// the game should run smoothly. If the game logic updates too slowly, 
            /// it can result in choppy or inconsistent gameplay, 
            /// so it's essential to strike a balance based on the specific requirements.
        }

        private void onGameTick(object sender, EventArgs e)
        {
            switch (currentState) 
            {
                case GameState.running:
                    IngameMenu.Hide();
                    Canvas.Focus(); // Focus on canvas to receive key inputs from event handlers.
                    ///if (playerList != null)
                    {
                        // Iterate through each player and update their game logic.
                        foreach (Player player in playerList)
                        {
                            player.Control(); // Call the Control method for each player to handle game logic.
                        }
                    }
                    
                    Debug.WriteLine("Current state running");
                  break;

                case GameState.menu:
                    Debug.WriteLine("current state: menu");
                    IngameMenu.Show();
                    break;

                case GameState.stopped:
                    Exit();
                  break;
            }

        }

        private void onRenderTick(object sender, EventArgs e)
        {
            if (playerList != null)
            {
                // Iterate through each player and render elements based on their properties.
                foreach (Player player in playerList)
                {
                    Canvas.SetLeft(player.Element, player.X);
                    Canvas.SetTop(player.Element, player.Y);
                    player.Element.RenderTransform = new RotateTransform(player.Angle, player.Element.Width / 2, player.Element.Height / 2); // Rotate the player's graphical element around its center point // // Call the Render method for each player to render their state.
                }
            }
        }

        public void keyHandler(object sender, KeyEventArgs e, bool isKeyDown)
        {
            // Send KeyDown or KeyUp event to player objects.
            foreach (Player ply in playerList)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (e.Key == ply.KeyControls[i])
                    {
                        ply.KeyDown[i] = isKeyDown; // Set the player's KeyDown state based on the event.
                    }
                }
            }

            if (e.Key == Key.Escape && isKeyDown == true)
            {   // toggle for pauze menu
                if (currentState == GameState.running) currentState = GameState.menu;
                else { currentState = GameState.running; }
            }
        }

        public void AddPlayer(string name, Key[] keyArray, double x, double y)
        {
            // Add a new player to the game.
            playerList.Add(new Player(Canvas, name, keyArray, x, y));
        }

        public void Start()
        {
            gameTimer.Start(); // Start the game timer.
            renderTimer.Start(); // Start the render timer.
            this.IngameMenu = new IngameMenu(Canvas); // initialize ingame menu
            
            currentState = GameState.running;
        }

        public void Exit()
        {
            gameTimer.Stop(); // Stop the game timer.
            renderTimer.Stop(); // Stop the render timer.
            currentState = GameState.stopped;
        }
    }

}
