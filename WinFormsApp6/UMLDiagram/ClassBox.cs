using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using WinFormsApp6.Data;

namespace WinFormsApp6
{
    public class ClassBox
    {
        public int Width;
        public int Height;
        public const int TITLE_HEIGHT = 20;
        public const int TITLE_FONT_SIZE = 10;
        public const int TEXT_FONT_SIZE = 8;

        private const int LINE_HEIGHT = 12;

        public Point TopLeftPoint { get; set; }

        public ClassData ClassData { get; set; }


        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);

            Rectangle rectangle = new Rectangle(this.TopLeftPoint.X, this.TopLeftPoint.Y, Width, Height);
            graphics.FillRectangle(Brushes.WhiteSmoke, rectangle);
            ControlPaint.DrawBorder(graphics, rectangle, Color.Black, ButtonBorderStyle.Solid);
            graphics.DrawLine(pen, this.TopLeftPoint.X, this.TopLeftPoint.Y + TITLE_HEIGHT, this.TopLeftPoint.X + Width, this.TopLeftPoint.Y + TITLE_HEIGHT);

            this.DrawTitle(graphics);
            this.DrawProperties(graphics);
            this.DrawMethods(graphics);
        }
        private void DrawTitle(Graphics graphics)
        {
            graphics.DrawString(
            this.ClassData.ClassName,
            new Font("Comic Sans MS", TITLE_FONT_SIZE),
            Brushes.Black,
            this.TopLeftPoint.X + 1, this.TopLeftPoint.Y + 1
            );
        }

        private void DrawProperties(Graphics graphics)
        {
            this.PrintLines(graphics, (from classProperty in ClassData.Properties select classProperty.ToString()).ToList(), this.GetPropertyListStartingPoint());
        }

        private void DrawMethods(Graphics graphics)
        {
            this.PrintLines(graphics, ClassData.Methods, this.GetMethodListStartingPoint());
        }

        private void PrintLines(Graphics graphics, List<string> lines, Point startingPoint)
        {
            foreach (string line in lines)
            {
                graphics.DrawString(

                    line,
                    new Font("Comic Sans MS", TEXT_FONT_SIZE),
                    Brushes.Black,
                    startingPoint
                    );
                startingPoint.Y += LINE_HEIGHT;
            }
        }

        private Point GetPropertyListStartingPoint()
        {
            return new Point(this.TopLeftPoint.X + 1, this.TopLeftPoint.Y + 20);
        }

        private Point GetMethodListStartingPoint()
        {
            Point propertyListStartingPoint = this.GetPropertyListStartingPoint();

            return new Point(propertyListStartingPoint.X, propertyListStartingPoint.Y + (ClassData.Properties.Count() * LINE_HEIGHT));
        }

        public bool IsPointInClassBox(Point point)
        {
            return point.X >= this.TopLeftPoint.X && point.X <= this.TopLeftPoint.X + Width
                && point.Y >= this.TopLeftPoint.Y && point.Y <= this.TopLeftPoint.Y + Height;
        }
    }
}
