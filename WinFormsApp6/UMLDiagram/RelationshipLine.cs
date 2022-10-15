namespace WinFormsApp6.UMLDiagram
{
    public class RelationshipLine
    {
        public const string LINE_TYPE_STRAIGHT = "straight";
        public const string LINE_TYPE_ORTHOGONAL = "orthogonal";

        private const int BOTTOM_TO_LEFT = 1;
        private const int BOTTOM_TO_RIGHT = 2;
        private const int BOTTOM_TO_TOP = 3;
        private const int LEFT_TO_BOTTOM = 4;
        private const int LEFT_TO_RIGHT = 5;
        private const int LEFT_TO_TOP = 6;
        private const int RIGHT_TO_BOTTOM = 7;
        private const int RIGHT_TO_LEFT = 8;
        private const int RIGHT_TO_TOP = 9;
        private const int TOP_TO_BOTTOM = 10;
        private const int TOP_TO_LEFT = 11;
        private const int TOP_TO_RIGHT = 12;

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public string Type { get; set; }

        private int JoinLocation { get; set; }

        
        public RelationshipLine(ClassBox sourceClassBox, ClassBox targetClassBox, string type)
        {
            switch (type)
            {
                case LINE_TYPE_STRAIGHT:
                    this.CreateStraightLine(sourceClassBox, targetClassBox);
                    break;

                case LINE_TYPE_ORTHOGONAL:
                    this.CreateOrthogonalLine(sourceClassBox, targetClassBox);
                    break;
                default:
                    throw new Exception("Neplatný typ!");
            }

            this.Type = type;
        }

        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);

            switch (this.Type)
            {
                case LINE_TYPE_STRAIGHT:
                    this.DrawStraightLine(graphics, pen);
                    return;

                case LINE_TYPE_ORTHOGONAL:
                    this.DrawOrthogonalLine(graphics, pen);
                    return;

                default:
                    throw new Exception("Neplatný typ!");
            }
        }

        private void DrawStraightLine(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, StartPoint, EndPoint);
        }

        private void DrawOrthogonalLine(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, StartPoint, EndPoint);
        }

        private void CreateStraightLine(ClassBox sourceClassBox, ClassBox targetClassBox)
        {
            this.StartPoint = sourceClassBox.GetCenterPoint();
            this.EndPoint = targetClassBox.GetCenterPoint();
        }

        private void CreateOrthogonalLine(ClassBox sourceClassBox, ClassBox targetClassBox)
        {

            Dictionary<int, int> joinPointDistances = new();

            joinPointDistances.Add(BOTTOM_TO_LEFT, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetBottomJointPoint(),
                targetClassBox.GetLeftJointPoint()
                ));

            joinPointDistances.Add(BOTTOM_TO_RIGHT, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetBottomJointPoint(),
                targetClassBox.GetRightJointPoint()
                ));

            joinPointDistances.Add(BOTTOM_TO_TOP, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetBottomJointPoint(),
                targetClassBox.GetTopJointPoint()
                ));

            joinPointDistances.Add(LEFT_TO_BOTTOM, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetLeftJointPoint(),
                targetClassBox.GetBottomJointPoint()
                ));

            joinPointDistances.Add(LEFT_TO_RIGHT, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetLeftJointPoint(),
                targetClassBox.GetRightJointPoint()
                ));

            joinPointDistances.Add(LEFT_TO_TOP, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetLeftJointPoint(),
                targetClassBox.GetTopJointPoint()
                ));

            joinPointDistances.Add(RIGHT_TO_BOTTOM, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetRightJointPoint(),
                targetClassBox.GetBottomJointPoint()
                ));

            joinPointDistances.Add(RIGHT_TO_LEFT, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetRightJointPoint(),
                targetClassBox.GetLeftJointPoint()
                ));

            joinPointDistances.Add(RIGHT_TO_TOP, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetRightJointPoint(),
                targetClassBox.GetTopJointPoint()
                ));

            joinPointDistances.Add(TOP_TO_BOTTOM, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetTopJointPoint(),
                targetClassBox.GetBottomJointPoint()
                ));

            joinPointDistances.Add(TOP_TO_LEFT, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetTopJointPoint(),
                targetClassBox.GetLeftJointPoint()
                ));

            joinPointDistances.Add(TOP_TO_RIGHT, GetOrthogonalDistanceBetweenPoints(
                sourceClassBox.GetTopJointPoint(),
                targetClassBox.GetRightJointPoint()
                ));

            KeyValuePair<int, int> shortestDistance = new KeyValuePair<int, int>(0, joinPointDistances.Values.Max() + 1);

            foreach (KeyValuePair<int, int> distance in joinPointDistances)
            {
                if (distance.Value < shortestDistance.Value)
                {
                    shortestDistance = distance;
                }
            }

            switch (shortestDistance.Key)
            {
                case BOTTOM_TO_LEFT:
                    this.StartPoint = sourceClassBox.GetBottomJointPoint();
                    this.EndPoint = targetClassBox.GetLeftJointPoint();
                    this.JoinLocation = BOTTOM_TO_LEFT;
                    break;

                case BOTTOM_TO_RIGHT:
                    this.StartPoint = sourceClassBox.GetBottomJointPoint();
                    this.EndPoint = targetClassBox.GetRightJointPoint();
                    this.JoinLocation = BOTTOM_TO_RIGHT;
                    break;

                case BOTTOM_TO_TOP:
                    this.StartPoint = sourceClassBox.GetBottomJointPoint();
                    this.EndPoint = targetClassBox.GetTopJointPoint();
                    this.JoinLocation = BOTTOM_TO_TOP;
                    break;

                case LEFT_TO_BOTTOM:
                    this.StartPoint = sourceClassBox.GetLeftJointPoint();
                    this.EndPoint = targetClassBox.GetBottomJointPoint();
                    this.JoinLocation = LEFT_TO_BOTTOM;
                    break;

                case LEFT_TO_RIGHT:
                    this.StartPoint = sourceClassBox.GetLeftJointPoint();
                    this.EndPoint = targetClassBox.GetRightJointPoint();
                    this.JoinLocation = LEFT_TO_RIGHT;
                    break;

                case LEFT_TO_TOP:
                    this.StartPoint = sourceClassBox.GetLeftJointPoint();
                    this.EndPoint = targetClassBox.GetTopJointPoint();
                    this.JoinLocation = LEFT_TO_TOP;
                    break;

                case RIGHT_TO_BOTTOM:
                    this.StartPoint = sourceClassBox.GetRightJointPoint();
                    this.EndPoint = targetClassBox.GetBottomJointPoint();
                    this.JoinLocation = RIGHT_TO_BOTTOM;
                    break;

                case RIGHT_TO_LEFT:
                    this.StartPoint = sourceClassBox.GetRightJointPoint();
                    this.EndPoint = targetClassBox.GetLeftJointPoint(); ;
                    this.JoinLocation = RIGHT_TO_LEFT;
                    break;

                case RIGHT_TO_TOP:
                    this.StartPoint = sourceClassBox.GetRightJointPoint();
                    this.EndPoint = targetClassBox.GetTopJointPoint();
                    this.JoinLocation = RIGHT_TO_TOP;
                    break;

                case TOP_TO_BOTTOM:
                    this.StartPoint = sourceClassBox.GetTopJointPoint();
                    this.EndPoint = targetClassBox.GetBottomJointPoint();
                    this.JoinLocation = TOP_TO_BOTTOM;
                    break;

                case TOP_TO_LEFT:
                    this.StartPoint = sourceClassBox.GetTopJointPoint();
                    this.EndPoint = targetClassBox.GetLeftJointPoint();
                    this.JoinLocation = TOP_TO_LEFT;
                    break;

                case TOP_TO_RIGHT:
                    this.StartPoint = sourceClassBox.GetTopJointPoint();
                    this.EndPoint = targetClassBox.GetRightJointPoint();
                    this.JoinLocation = TOP_TO_RIGHT;
                    break;

                default:
                    throw new Exception("Neplatná kombinace!");
            }

        }

        private int GetOrthogonalDistanceBetweenPoints(Point pointA, Point pointB)
        {
            return Math.Abs(pointA.X - pointB.X) + Math.Abs(pointA.Y - pointB.Y);
        }
    }
}
