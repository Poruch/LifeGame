using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal abstract class Object : Point
    {
        
        protected Color _Color;
        
        protected int L = Form1.scale;
      
        protected Object(Color color, int x,int y)
        {
            _Color = color;
            X = x;
            Y = y;  
        }
        public virtual void Paint(Graphics graphics)
        {
            L = Form1.scale;
            var brush = new SolidBrush(_Color);
            graphics.FillRectangle(brush,X*L,Y*L,L-1,L-1);
        }
        
    }
}
