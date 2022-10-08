namespace WinFormsApp6.UMLDiagram
{
    public class ClassBoxMover
    {
        public Point LastMousePoint { get; set; } = new Point();
        public ClassBox? MovingClassBox { get; set; }

        public void StartMoving(ClassBox classBox, Point currentMousePoint)
        {
            this.MovingClassBox = classBox;
            this.LastMousePoint = currentMousePoint;
        }

        public void StopMoving()
        {
            this.MovingClassBox = null;
        }

        public void UpdateDiagram(Point currentMousePoint)
        {
            if (this.MovingClassBox == null)
            {
                return;
            }

            this.MovingClassBox.TopLeft = new Point(
                this.MovingClassBox.TopLeft.X + (currentMousePoint.X - this.LastMousePoint.X),
                this.MovingClassBox.TopLeft.Y + (currentMousePoint.Y - this.LastMousePoint.Y)
                );

            this.LastMousePoint = currentMousePoint;
        }
    }
}