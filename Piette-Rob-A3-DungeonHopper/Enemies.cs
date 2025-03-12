using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Enemy
    {
        float y;
        float speed = 200;
        float direction = 1; 
        float maxY = 600;  
        float minY = 0;

        public bool CheckPlayerCollision(Player player)
        {
            // Check collision with each Enemy
            
            // Enemy 1 
            if (IsPointInTriangle(player.X, player.Y, 125, 0 + y, 140, 30 + y, 110, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y, 125, 0 + y, 140, 30 + y, 110, 30 + y) ||
                IsPointInTriangle(player.X, player.Y + player.Height, 125, 0 + y, 140, 30 + y, 110, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y + player.Height, 125, 0 + y, 140, 30 + y, 110, 30 + y))
            {
                return true; 
            }
            // Enemy 2
            if (IsPointInTriangle(player.X, player.Y, 225, 0 + y, 240, 30 + y, 210, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y, 225, 0 + y, 240, 30 + y, 210, 30 + y) ||
                IsPointInTriangle(player.X, player.Y + player.Height, 225, 0 + y, 240, 30 + y, 210, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y + player.Height, 225, 0 + y, 240, 30 + y, 210, 30 + y))
            {
                return true;
            }
            // Enemy 3
            if (IsPointInTriangle(player.X, player.Y, 325, 0 + y, 340, 30 + y, 1310, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y, 325, 0 + y, 340, 30 + y, 310, 30 + y) ||
                IsPointInTriangle(player.X, player.Y + player.Height, 325, 0 + y, 340, 30 + y, 310, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y + player.Height, 325, 0 + y, 340, 30 + y, 310, 30 + y))
            {
                return true; 
            }
            // Enemy 4
            if (IsPointInTriangle(player.X, player.Y, 525, 0 + y, 540, 30 + y, 510, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y, 525, 0 + y, 540, 30 + y, 510, 30 + y) ||
                IsPointInTriangle(player.X, player.Y + player.Height, 525, 0 + y, 540, 30 + y, 510, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y + player.Height, 525, 0 + y, 540, 30 + y, 510, 30 + y))
            {
                return true; 
            }
            // Enemy 5
            if (IsPointInTriangle(player.X, player.Y, 625, 0 + y, 640, 30 + y, 610, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y, 625, 0 + y, 640, 30 + y, 610, 30 + y) ||
                IsPointInTriangle(player.X, player.Y + player.Height, 625, 0 + y, 640, 30 + y, 610, 30 + y) ||
                IsPointInTriangle(player.X + player.Width, player.Y + player.Height, 625, 0 + y, 640, 30 + y, 610, 30 + y))
            {
                return true;
            }

            return false; 
        }

        // Check if a point is inside a triangle
        private bool IsPointInTriangle(float px, float py, float x1, float y1, float x2, float y2, float x3, float y3)
        {
            float d1, d2, d3;
            bool has_neg, has_pos;

            d1 = Sign(px, py, x1, y1, x2, y2);
            d2 = Sign(px, py, x2, y2, x3, y3);
            d3 = Sign(px, py, x3, y3, x1, y1);

            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(has_neg && has_pos);
        }

        
        private float Sign(float px, float py, float x1, float y1, float x2, float y2)
        {
            return (px - x2) * (y1 - y2) - (x1 - x2) * (py - y2);
        }
    
        // Update the position of the enemy based on DeltaTime and direction
        public void enemyPosition()
        {
            
            y += Time.DeltaTime * speed * direction;

            // Check for collisions with top or bottom and reverse direction if necessary
            if (y >= maxY)
            {
                y = maxY; 
                direction = -1;
            }
            if (y <= minY)
            {
                y = minY; 
                direction = 1; 
            }
        }
      
        public void renderEnemy()
        { 

            Draw.FillColor = Color.Red;
            Draw.Triangle(125, 0 + y, 140, 30 + y, 110, 30 + y);
            Draw.Triangle(225, 0 + y, 240, 30 + y, 210, 30 + y);
            Draw.Triangle(325, 0 + y, 340, 30 + y, 310, 30 + y);
            Draw.Triangle(525, 0 + y, 540, 30 + y, 510, 30 + y);
            Draw.Triangle(625, 0 + y, 640, 30 + y, 610, 30 + y);
        }
    }
}
