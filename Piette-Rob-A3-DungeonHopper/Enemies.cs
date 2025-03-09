using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
   public class Enemy
    {
  
        public void renderEnemy()
        {
            Draw.FillColor = Color.Red;
            Draw.Triangle(225, 300, 240, 330, 210, 330);
            Draw.Triangle(325, 300, 340, 330, 310, 330);
            Draw.Triangle(525, 300, 540, 330, 510, 330);
            Draw.Triangle(625, 300, 640, 330, 610, 330);
            Draw.Triangle(175, 50, 190, 80, 160, 80);
        }
    }
}
