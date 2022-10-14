using WinFormsApp6.Data;

namespace WinFormsApp6
{
    public class ClassBox
    {
        private const int PADDING = 2;
        private const int HORIZONTAL_EXTRA_PADDING = 10;
        private const int EMPTY_BODY_HEIGHT = 20;

        public Point TopLeft { get; set; }

        public ClassData ClassData { get; set; }

        public void Draw(Graphics graphics, bool isSelected, List<ClassBox> relatedClassBoxes)
        {
            this.DrawFrame(graphics, isSelected);
            this.DrawTexts(graphics);
            this.DrawRelationships(graphics, relatedClassBoxes);
        }

        public bool IsPointInClassBox(Point point)
        {
            return point.X >= this.TopLeft.X && point.X <= this.TopLeft.X + GetWidth()
                && point.Y >= this.TopLeft.Y && point.Y <= this.TopLeft.Y + GetHeight();
        }

        public int GetHeight()
        {
            if (this.ClassData.Properties.Count == 0 && this.ClassData.Methods.Count == 0)
            {
                return this.GetTitleHeight() + EMPTY_BODY_HEIGHT;
            }

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

            foreach (ClassMethod classMethod in this.ClassData.Methods)
            {
                classStrings.Add(classMethod.ToString());
            }

            string longestClassString = classStrings.OrderByDescending(classString => classString.Length).First();

            return TextRenderer.MeasureText(longestClassString, SystemFonts.DefaultFont).Width + PADDING * 2 + HORIZONTAL_EXTRA_PADDING;
        }

        private void DrawFrame(Graphics graphics, bool isSelected)
        {
            Pen pen = new Pen(Color.Black, isSelected ? 2 : 1);

            Rectangle rectangle = new Rectangle(this.TopLeft.X, this.TopLeft.Y, this.GetWidth(), this.GetHeight());
            graphics.FillRectangle(Brushes.WhiteSmoke, rectangle);
            graphics.DrawRectangle(pen, rectangle);

            if (ClassData.IsInterface)
            {
                this.DrawInterface(graphics, pen);
            }

            pen.Width = 1;
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
            this.PrintLines(graphics, (from classMethod in ClassData.Methods select classMethod.ToString()).ToList(), this.GetMethodListStartingPoint());
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

        private void DrawInterface(Graphics graphics, Pen pen)
        {
            Rectangle interfaceRectangle = new Rectangle(this.TopLeft.X, this.TopLeft.Y - 15, this.GetWidth(), 15);
            Font interfaceFont = new Font("Arial", 13, FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.DrawRectangle(pen, interfaceRectangle);
            graphics.DrawString(
                ":interface",
                interfaceFont,
                Brushes.Black,
                this.TopLeft.X + 30,
                this.TopLeft.Y - 15);
        }
        private void DrawRelationships(Graphics graphics, List<ClassBox> relatedClassBoxes)
        { 
            Pen pen = new Pen(Color.Black);

            foreach (ClassBox relatedClassBox in relatedClassBoxes)
            {
                this.DrawRelationship(graphics, pen, relatedClassBox.TopLeft);
            }
        }


        private void DrawRelationship(Graphics graphics, Pen pen, Point relatedClassboxTopLeftPoint)
        {
            graphics.DrawLine(pen, TopLeft, relatedClassboxTopLeftPoint);
        }

        private Point GetPropertyListStartingPoint()
        {
            return new Point(this.TopLeft.X + PADDING, this.TopLeft.Y + this.GetTitleHeight() + PADDING);
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
            if (this.ClassData.Properties.Count == 0)
            {
                return 0;
            }

            return this.ClassData.Properties.Count * SystemFonts.DefaultFont.Height + PADDING * 2;
        }

        private int GetMethodsSectionHeight()
        {
            if (this.ClassData.Methods.Count == 0)
            {
                return 0;
            }

            return this.ClassData.Methods.Count * SystemFonts.DefaultFont.Height + PADDING * 2;
        }
    }
}
