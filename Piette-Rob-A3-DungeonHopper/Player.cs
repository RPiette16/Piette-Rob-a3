﻿using System;
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
        Vector2 position;
        public void Render()
        {
            //Draw Character
            Draw.FillColor = Color.Magenta;
            Draw.Rectangle(10, 510, 30, 30);
            
        }

   
    }
}
