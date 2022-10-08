using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6.Diagram
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

            this.MovingClassBox.TopLeftPoint = new Point(
                this.MovingClassBox.TopLeftPoint.X + (currentMousePoint.X - this.LastMousePoint.X),
                this.MovingClassBox.TopLeftPoint.Y + (currentMousePoint.Y - this.LastMousePoint.Y)
                );

            this.LastMousePoint = currentMousePoint;
        }
    }
}