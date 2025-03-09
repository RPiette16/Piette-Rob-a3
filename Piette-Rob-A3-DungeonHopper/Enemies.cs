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
        }
    }
}
