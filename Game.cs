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

            DrawDiamond(-200, 0);
            DrawDiamond(200, 0); 
            DrawDiamond(0, -100);
            DrawDiamond(0, 100);





        }
         void DrawDiamond(int offsetX, int offsetY)
        {
            // Draw fill color
            Draw.FillColor = Color.Blue;
            Draw.LineColor = Color.Black;
            Draw.Line(400 + offsetX, 200 + offsetY, 500 + offsetX, 200 + offsetY);
            Draw.Line(500 + offsetX, 200 + offsetY, 550 + offsetX, 250 + offsetY);
            Draw.Line(550 + offsetX, 250 + offsetY, 400 + offsetX, 350 + offsetY);
            Draw.Line(400 + offsetX, 350 + offsetY, 250 + offsetX, 250 + offsetY);
            Draw.Line(250 + offsetX, 250 + offsetY, 300 + offsetX, 200 + offsetY);
            Draw.Line(300 + offsetX, 200 + offsetY, 400 + offsetX, 200 + offsetY);
            Draw.Line(450 + offsetX, 200 + offsetY, 500 + offsetX, 250 + offsetY);
            Draw.Line(500 + offsetX, 250 + offsetY, 400 + offsetX, 350 + offsetY);
            Draw.Line(400 + offsetX, 350 + offsetY, 300 + offsetX, 250 + offsetY);
            Draw.Line(250 + offsetX, 250 + offsetY, 550 + offsetX, 250 + offsetY);
            Draw.Line(400 + offsetX, 200 + offsetY, 400 + offsetX, 350 + offsetY);
            Draw.Line(300 + offsetX, 250 + offsetY, 350 + offsetX, 200 + offsetY);

            
            Draw.FillColor = new Color(137, 207, 240);
            Draw.LineColor = Color.Black;
            Draw.LineSize = (2);
            Draw.Quad(250 + offsetX, 250 + offsetY, 300 + offsetX, 250 + offsetY, 350 + offsetX, 200 + offsetY, 300 + offsetX, 200 + offsetY);
            Draw.Quad(300 + offsetX, 250 + offsetY, 350 + offsetX, 200 + offsetY, 400 + offsetX, 200 + offsetY, 400 + offsetX, 250 + offsetY);
            Draw.Quad(400 + offsetX, 250 + offsetY, 400 + offsetX, 200 + offsetY, 450 + offsetX, 200 + offsetY, 500 + offsetX, 250 + offsetY);
            Draw.Quad(450 + offsetX, 200 + offsetY, 500 + offsetX, 200 + offsetY, 550 + offsetX, 250 + offsetY, 500 + offsetX, 250 + offsetY);
            Draw.Triangle(250 + offsetX, 250 + offsetY, 300 + offsetX, 250 + offsetY, 400 + offsetX, 350 + offsetY);
            Draw.Triangle(300 + offsetX, 250 + offsetY, 400 + offsetX, 250 + offsetY, 400 + offsetX, 350 + offsetY);
            Draw.Triangle(400 + offsetX, 350 + offsetY, 400 + offsetX, 250 + offsetY, 500 + offsetX, 250 + offsetY);
            Draw.Triangle(400 + offsetX, 350 + offsetY, 500 + offsetX, 250 + offsetY, 550 + offsetX, 250 + offsetY);
        }
    } 
}
