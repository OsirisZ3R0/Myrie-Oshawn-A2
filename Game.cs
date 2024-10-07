// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {

        // Place your variables here:
       


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Shiney Diamond");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            // Draw fill color
            Draw.FillColor = Color.Blue;
            Draw.LineColor = Color.Black;
            Draw.Line(400, 200, 500, 200);
            Draw.Line(500, 200, 550, 250);
            Draw.Line(550, 250, 400, 350);
            Draw.Line(400, 350, 250, 250);
            Draw.Line(250, 250, 300, 200);
            Draw.Line(300, 200, 400, 200);
            Draw.Line(450, 200, 500, 250);
            Draw.Line(500, 250, 400, 350);
            Draw.Line(400, 350, 300, 250);
            Draw.Line(250, 250, 550, 250);
            Draw.Line(400, 200, 400, 350);
            Draw.Line(300, 250, 350, 200);

            






        }
    } 
}
