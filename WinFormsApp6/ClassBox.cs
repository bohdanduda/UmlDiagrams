using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class ClassBox
    {
        public int Width;
        public int Height;
        public const int TITLE_HEIGHT = 20;
        public const int TITLE_FONT_SIZE = 10;
        public Point TopLeftPoint { get; set; }

       public ClassData ClassData { get; set; } 

        
        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);
            
            Rectangle rectangle = new Rectangle(this.TopLeftPoint.X, this.TopLeftPoint.Y, Width, Height);
            graphics.FillRectangle(Brushes.WhiteSmoke, rectangle);
            ControlPaint.DrawBorder(graphics, rectangle, Color.Black, ButtonBorderStyle.Solid);
            graphics.DrawLine(pen, this.TopLeftPoint.X, this.TopLeftPoint.Y + TITLE_HEIGHT, this.TopLeftPoint.X+Width, this.TopLeftPoint.Y+TITLE_HEIGHT);

            graphics.DrawString(
                this.ClassData.ClassName,
                new Font("Comic Sans MS", TITLE_FONT_SIZE),
                Brushes.Black,
                this.TopLeftPoint.X + 1, this.TopLeftPoint.Y + 1
                );
        }

        public bool IsPointInClassBox(Point point)
        {
            return point.X >= this.TopLeftPoint.X && point.X <= this.TopLeftPoint.X + Width 
                && point.Y >= this.TopLeftPoint.Y && point.Y <= this.TopLeftPoint.Y + Height;
        }
    }
}
