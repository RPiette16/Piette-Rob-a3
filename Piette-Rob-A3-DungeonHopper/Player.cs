using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace MohawkGame2D
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Speed { get; set; } = 5;
        public bool IsJumping { get; set; } = false;
        public bool IsFalling { get; set; } = false;

        public Player()
        {
            X = 10;
            Y = 510;
            Width = 30;
            Height = 30;
        }
        public void renderPlayer()
        {
            //Draw Character
            Draw.FillColor = Color.Magenta;
            Draw.Rectangle(X, Y, Width, Height);
        }
        public void movePlayer()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                X += Speed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                X -= Speed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Y -= Speed;
            }
        }
    }
}
