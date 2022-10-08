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
        private const int LINE_HEIGHT = 12;
        private const int PADDING = 2;

        public Point TopLeft { get; set; }

        public ClassData ClassData { get; set; }

        public void Draw(Graphics graphics)
        {
            this.DrawFrame(graphics);
            this.DrawTexts(graphics);
        }

        public bool IsPointInClassBox(Point point)
        {
            return point.X >= this.TopLeft.X && point.X <= this.TopLeft.X + GetWidth()
                && point.Y >= this.TopLeft.Y && point.Y <= this.TopLeft.Y + GetWidth();
        }

        public int GetHeight()
        {
            return this.GetTitleHeight() + this.GetPropertiesSectionHeight() + this.GetMethodsSectionHeight();
        }

        public int GetWidth()
        {
            return 100;
        }

        private void DrawFrame(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);

            Rectangle rectangle = new Rectangle(this.TopLeft.X, this.TopLeft.Y, this.GetWidth(), this.GetHeight());
            graphics.FillRectangle(Brushes.WhiteSmoke, rectangle);
            graphics.DrawRectangle(pen, rectangle);

            graphics.DrawLine(
                pen,
                this.TopLeft.X,
                this.TopLeft.Y + this.GetTitleHeight(),
                this.TopLeft.X + this.GetWidth(),
                this.TopLeft.Y + this.GetTitleHeight()
                );

            if (this.ClassData.Properties.Count > 0 && this.ClassData.Methods.Count > 0)
            {
                graphics.DrawLine(
                    pen,
                    this.TopLeft.X,
                    this.TopLeft.Y + this.GetTitleHeight() + this.GetPropertiesSectionHeight(),
                    this.TopLeft.X + this.GetWidth(),
                    this.TopLeft.Y + this.GetTitleHeight() + this.GetPropertiesSectionHeight()
                    );
            }
        }

        private void DrawTexts(Graphics graphics)
        {
            this.DrawTitle(graphics);
            this.DrawProperties(graphics);
            this.DrawMethods(graphics);
        }

        private void DrawTitle(Graphics graphics)
        {
            graphics.DrawString(
            this.ClassData.ClassName,
            new (SystemFonts.DefaultFont, FontStyle.Bold),
            Brushes.Black,
            this.TopLeft.X + PADDING, this.TopLeft.Y + PADDING
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
                    SystemFonts.DefaultFont,
                    Brushes.Black,
                    startingPoint
                    );
                startingPoint.Y += LINE_HEIGHT;
            }
        }

        private Point GetPropertyListStartingPoint()
        {
            return new Point(this.TopLeft.X + PADDING, this.TopLeft.Y + 20);
        }

        private Point GetMethodListStartingPoint()
        {
            Point propertyListStartingPoint = this.GetPropertyListStartingPoint();

            return new Point(propertyListStartingPoint.X, propertyListStartingPoint.Y + this.GetPropertiesSectionHeight());
        }

        private int GetTitleHeight()
        {
            return SystemFonts.DefaultFont.Height + PADDING * 2;
        }

        private int GetPropertiesSectionHeight()
        {
            return this.ClassData.Properties.Count * SystemFonts.DefaultFont.Height + PADDING * 2;
        }

        private int GetMethodsSectionHeight()
        {
            return this.ClassData.Methods.Count * SystemFonts.DefaultFont.Height + PADDING * 2;
        }
    }
}
