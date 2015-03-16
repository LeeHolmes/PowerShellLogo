using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace PowerShellLogo
{
    /// <summary>
    /// A turtle class that implements some of the logo primitives.
    /// It stores a reference to the canvas upon which it draws, and
    /// is responsible for drawing on that canvas.
    /// </summary>
    class Turtle
    {
        Graphics canvas;
        Pen drawingPen = new Pen(Color.LightGreen);

        // Although the canvas can only represent integer
        // positions, we store our state in double precision.
        // Otherwise, most interesting graphics (that tend to
        // involve recursion and small numbers) look terribly
        // broken.
        double currentX, currentY;
        bool penDown = true;
        bool showTurtle = true;
        int direction = 90;

        public Turtle(Graphics canvas)
        {
            this.canvas = canvas;

            Initialize();
        }

        public void PenUp()
        {
            penDown = false;
        }

        public void PenDown()
        {
            penDown = true;
        }

        public void Forward(double steps)
        {
            int oldX = (int) currentX;
            int oldY = (int) currentY;

            // In essense, the turtle draws the hypotenuse
            // of a triangle as it moves.  Since the user provides
            // the length of the hypotenuse, we use standard
            // trigonometry to determine the X and Y components
            // of the movement independently.
            currentX += steps * Math.Cos(DegToRad(direction));
            currentY -= steps * Math.Sin(DegToRad(direction));

            if(penDown)
            {
                canvas.DrawLine(drawingPen, oldX, oldY, 
                    (int) currentX, (int) currentY);
            }
        }

        public void Backward(double steps)
        {
            Forward(-1 * steps);
        }

        public void Left(int degrees)
        {
            direction = (direction + degrees) % 360;
        }

        public void Right(int degrees)
        {
            direction = (direction - degrees + 360) % 360;
        }

        public void Hide()
        {
            showTurtle = false;
        }

        public void Show()
        {
            showTurtle = true;
        }

        public void Draw()
        {
            if (showTurtle)
            {
                // We leverage the 2d transformations of the .Net
                // Graphics class here to save us from doing the 
                // math for rotation contortions ourselves.
                // Rather than draw a rotated turtle, we instead rotate
                // (and reposition) the canvas, then draw a straight
                // turtle.  When we restore the canvas again, the
                // turtle now appears rotated.

                System.Drawing.Drawing2D.GraphicsState canvasState = 
                    canvas.Save();
                canvas.TranslateTransform((float) currentX, (float) currentY);
                canvas.RotateTransform(90 - direction);

                canvas.DrawLine(drawingPen, -4, 4, 0, -8);
                canvas.DrawLine(drawingPen, 0, -8, 4, 4);
                canvas.DrawLine(drawingPen, -4, 4, 4, 4);

                canvas.Restore(canvasState);
            }
        }

        public void Reset()
        {
            Initialize();
            canvas.Clear(Color.DarkGreen);
        }

        private void Initialize()
        {
            currentX = canvas.VisibleClipBounds.Width / 2.0;
            currentY = canvas.VisibleClipBounds.Height / 2.0;

            penDown = true;
            showTurtle = true;
            direction = 90;
        }

        // The user specifies their angles in degrees, but
        // the .Net math classes prefer radians.
        private double DegToRad(int degrees)
        {
            return (Math.PI * (double) degrees / 180.0);
        }
    }
}
