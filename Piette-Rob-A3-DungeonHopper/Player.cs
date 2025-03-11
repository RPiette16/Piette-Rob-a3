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
        public int VerticalSpeed { get; set; } = 0;
        public bool IsJumping { get; set; } = false;
        public bool IsFalling { get; set; } = false;

        public Player()
        {
            X = 10;
            Y = 500;
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
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space) && !IsJumping)
            {
                IsJumping = true;
                VerticalSpeed = -15;
            }
        }
        public void updateMovement(Platform[] platforms)
        {
            bool isOnGround = false;

            // Handle platform collisions
            foreach (var platform in platforms)
            {
                if (platform.CheckCollision(this))
                {
                    // Player is landing on the platform
                    Y = platform.Y - Height;  // Position the player just above the platform
                    VerticalSpeed = 0;        // Stop vertical movement (no more falling)
                    IsJumping = false;        // Player is no longer jumping
                    isOnGround = true;        // Player is on the ground
                    break; // Stop checking once the player lands on the first platform
                }
            }

            // If the player is not standing on a platform, apply gravity
            if (!isOnGround)
            {
                VerticalSpeed += 1; // Gravity effect
            }

            // Update Y position based on vertical speed
            Y += VerticalSpeed;

            // Prevent falling too fast by limiting vertical speed
            if (VerticalSpeed > 10)
                VerticalSpeed = 10;  // Maximum fall speed
        }
    }
}   
