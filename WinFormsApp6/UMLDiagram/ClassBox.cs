﻿using WinFormsApp6.Data;
using WinFormsApp6.UMLDiagram;

namespace WinFormsApp6
{
    public class ClassBox
    {
        private const int PADDING = 2;
        private const int HORIZONTAL_EXTRA_PADDING = 10;

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
                && point.Y >= this.TopLeft.Y && point.Y <= this.TopLeft.Y + GetHeight();
        }

        public int GetHeight()
        {
            return this.GetTitleHeight() + this.GetPropertiesSectionHeight() + this.GetMethodsSectionHeight();
        }

        public int GetWidth()
        {
            List<string> classStrings = new();

            classStrings.Add(this.ClassData.ClassName);

            foreach (ClassProperty classProperty in this.ClassData.Properties)
            {
                classStrings.Add(classProperty.ToString());
            }

            foreach (string classMethodName in this.ClassData.Methods)
            {
                classStrings.Add(classMethodName);
            }

            string longestClassString = classStrings.OrderByDescending(classString => classString.Length).First();

            return TextRenderer.MeasureText(longestClassString, SystemFonts.DefaultFont).Width + PADDING * 2 + HORIZONTAL_EXTRA_PADDING;
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
            new(SystemFonts.DefaultFont, FontStyle.Bold),
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
                startingPoint.Y += SystemFonts.DefaultFont.Height;
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
