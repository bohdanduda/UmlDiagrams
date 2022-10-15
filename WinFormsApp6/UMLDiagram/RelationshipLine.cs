using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using WinFormsApp6.Data;

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
        public string LineType { get; set; }
        private string relationshipType { get; set; }

        private int joinType { get; set; }


        public RelationshipLine(ClassBox sourceClassBox, ClassBox targetClassBox, string lineType)
        {
            switch (lineType)
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

            this.relationshipType = this.GetRelationshipTypeForClass(sourceClassBox.ClassData.Relationships, targetClassBox.ClassData.ClassName);
            this.LineType = lineType;
        }

        public void Draw(Graphics graphics)
        {
            switch (this.LineType)
            {
                case LINE_TYPE_STRAIGHT:
                    this.DrawStraightLine(graphics);
                    return;

                case LINE_TYPE_ORTHOGONAL:
                    this.DrawOrthogonalLine(graphics);
                    return;

                default:
                    throw new Exception("Neplatný typ!");
            }
        }

        private void DrawStraightLine(Graphics graphics)
        {
            Pen pen = this.GetPen();
            pen.CustomEndCap = this.GetCustomLineCap();
            graphics.DrawLine(pen, StartPoint, EndPoint);
        }

        private void DrawOrthogonalLine(Graphics graphics)
        {
            Pen pen = this.GetPen();

            if (this.IsJoinTypeRectangularVertical())
            {
                Point breakPoint = new(this.StartPoint.X, this.EndPoint.Y);
                graphics.DrawLine(pen, StartPoint, breakPoint);
                pen.CustomEndCap = this.GetCustomLineCap();
                graphics.DrawLine(pen, breakPoint, EndPoint);

                return;
            }

            if (this.IsJoinTypeRectangularHorizontal())
            {
                Point breakPoint = new(this.EndPoint.X, StartPoint.Y);
                graphics.DrawLine(pen, StartPoint, breakPoint);
                pen.CustomEndCap = this.GetCustomLineCap();
                graphics.DrawLine(pen, breakPoint, EndPoint);

                return;
            }

            if (this.IsJointTypeHorizontal())
            {
                int horizontalDistance = this.EndPoint.X - this.StartPoint.X;
                Point breakPoint1 = new(this.StartPoint.X + (int)(horizontalDistance / 2), this.StartPoint.Y);
                Point breakPoint2 = new(breakPoint1.X, this.EndPoint.Y);

                graphics.DrawLine(pen, StartPoint, breakPoint1);
                graphics.DrawLine(pen, breakPoint1, breakPoint2);
                pen.CustomEndCap = this.GetCustomLineCap();
                graphics.DrawLine(pen, breakPoint2, EndPoint);

                return;
            }

            if (this.IsJoinTypeVertical())
            {
                int verticalDistance = this.EndPoint.Y - this.StartPoint.Y;
                Point breakPoint1 = new(StartPoint.X, StartPoint.Y + (int)(verticalDistance / 2));
                Point breakPoint2 = new(EndPoint.X, breakPoint1.Y);

                graphics.DrawLine(pen, StartPoint, breakPoint1);
                graphics.DrawLine(pen, breakPoint1, breakPoint2);
                pen.CustomEndCap = this.GetCustomLineCap();
                graphics.DrawLine(pen, breakPoint2, EndPoint);

                return;
            }
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
                    this.joinType = BOTTOM_TO_LEFT;
                    break;

                case BOTTOM_TO_RIGHT:
                    this.StartPoint = sourceClassBox.GetBottomJointPoint();
                    this.EndPoint = targetClassBox.GetRightJointPoint();
                    this.joinType = BOTTOM_TO_RIGHT;
                    break;

                case BOTTOM_TO_TOP:
                    this.StartPoint = sourceClassBox.GetBottomJointPoint();
                    this.EndPoint = targetClassBox.GetTopJointPoint();
                    this.joinType = BOTTOM_TO_TOP;
                    break;

                case LEFT_TO_BOTTOM:
                    this.StartPoint = sourceClassBox.GetLeftJointPoint();
                    this.EndPoint = targetClassBox.GetBottomJointPoint();
                    this.joinType = LEFT_TO_BOTTOM;
                    break;

                case LEFT_TO_RIGHT:
                    this.StartPoint = sourceClassBox.GetLeftJointPoint();
                    this.EndPoint = targetClassBox.GetRightJointPoint();
                    this.joinType = LEFT_TO_RIGHT;
                    break;

                case LEFT_TO_TOP:
                    this.StartPoint = sourceClassBox.GetLeftJointPoint();
                    this.EndPoint = targetClassBox.GetTopJointPoint();
                    this.joinType = LEFT_TO_TOP;
                    break;

                case RIGHT_TO_BOTTOM:
                    this.StartPoint = sourceClassBox.GetRightJointPoint();
                    this.EndPoint = targetClassBox.GetBottomJointPoint();
                    this.joinType = RIGHT_TO_BOTTOM;
                    break;

                case RIGHT_TO_LEFT:
                    this.StartPoint = sourceClassBox.GetRightJointPoint();
                    this.EndPoint = targetClassBox.GetLeftJointPoint(); ;
                    this.joinType = RIGHT_TO_LEFT;
                    break;

                case RIGHT_TO_TOP:
                    this.StartPoint = sourceClassBox.GetRightJointPoint();
                    this.EndPoint = targetClassBox.GetTopJointPoint();
                    this.joinType = RIGHT_TO_TOP;
                    break;

                case TOP_TO_BOTTOM:
                    this.StartPoint = sourceClassBox.GetTopJointPoint();
                    this.EndPoint = targetClassBox.GetBottomJointPoint();
                    this.joinType = TOP_TO_BOTTOM;
                    break;

                case TOP_TO_LEFT:
                    this.StartPoint = sourceClassBox.GetTopJointPoint();
                    this.EndPoint = targetClassBox.GetLeftJointPoint();
                    this.joinType = TOP_TO_LEFT;
                    break;

                case TOP_TO_RIGHT:
                    this.StartPoint = sourceClassBox.GetTopJointPoint();
                    this.EndPoint = targetClassBox.GetRightJointPoint();
                    this.joinType = TOP_TO_RIGHT;
                    break;

                default:
                    throw new Exception("Neplatná kombinace!");
            }

        }

        private int GetOrthogonalDistanceBetweenPoints(Point pointA, Point pointB)
        {
            return Math.Abs(pointA.X - pointB.X) + Math.Abs(pointA.Y - pointB.Y);
        }

        private bool IsJoinTypeRectangularVertical()
        {
            int[] rectangularTypes = {
            BOTTOM_TO_LEFT,
            BOTTOM_TO_RIGHT,
            TOP_TO_LEFT,
            TOP_TO_RIGHT,
            };

            return rectangularTypes.Contains(this.joinType);
        }

        private bool IsJoinTypeRectangularHorizontal()
        {
            int[] rectangularTypes = {
            LEFT_TO_BOTTOM,
            LEFT_TO_TOP,
            RIGHT_TO_BOTTOM,
            RIGHT_TO_TOP,
            };

            return rectangularTypes.Contains(this.joinType);
        }

        private bool IsJoinTypeVertical()
        {
            int[] horizontalTypes = {
                TOP_TO_BOTTOM,
                BOTTOM_TO_TOP
            };
            return horizontalTypes.Contains(this.joinType);
        }

        private bool IsJointTypeHorizontal()
        {
            int[] verticalTypes = {
                LEFT_TO_RIGHT,
                RIGHT_TO_LEFT
            };
            return verticalTypes.Contains(this.joinType);
        }

        private string GetRelationshipTypeForClass(List<ClassRelationship> relationships, string relatedClassName)
        {
            foreach (ClassRelationship relationship in relationships)
            {
                if (relationship.RelatedClassName == relatedClassName)
                {
                    return relationship.Type;
                }
            }

            throw new Exception("Vztah pro třídu neexistuje");
        }

        private CustomLineCap GetCustomLineCap()
        {
            GraphicsPath capPath = new GraphicsPath();

            switch (this.relationshipType)
            {
                case RelationshipType.ASSOCIATION:
                    capPath.AddLine(0, 0, -10, -10);
                    capPath.AddLine(0, 0, 10, -10);
                    return new CustomLineCap(null, capPath);

                case RelationshipType.INHERITANCE:
                    capPath.AddLine(0, 0, -10, -10);
                    capPath.AddLine(-10, -10, 10, -10);
                    capPath.AddLine(0, 0, 10, -10);
                    return new CustomLineCap(null, capPath);

                case RelationshipType.IMPLEMENTATION:
                    capPath.AddLine(0, 0, -10, -10);
                    capPath.AddLine(-10, -10, 10, -10);
                    capPath.AddLine(0, 0, 10, -10);
                    return new CustomLineCap(null, capPath);

                case RelationshipType.DEPENDENCY:
                    capPath.AddLine(0, 0, -10, -10);
                    capPath.AddLine(0, 0, 10, -10);
                    return new CustomLineCap(null, capPath);

                case RelationshipType.AGGREGATION:
                    capPath.AddLine(0, 0, 10, -15);
                    capPath.AddLine(10, -15, 0, -30);
                    capPath.AddLine(0, -30, -10, -15);
                    capPath.AddLine(-10, -15, 0, 0);
                    return new CustomLineCap(null, capPath);

                case RelationshipType.COMPOSITION:
                    capPath.AddLine(0, 0, 5, -10);
                    capPath.AddLine(5, -10, 0, -20);
                    capPath.AddLine(0, -20, -5, -10);
                    capPath.AddLine(-5, -10, 0, 0);
                    return new CustomLineCap(capPath, null);

                default:
                    throw new Exception("Neplatný typ vztahu!");
            }

            
        }

        private Pen GetPen()
        {
            Pen pen = new Pen(Color.Black);
            if (this.relationshipType == RelationshipType.IMPLEMENTATION || this.relationshipType == RelationshipType.DEPENDENCY)
            {
                float[] dashValues = { 7, 7 };
                pen.DashPattern = dashValues;
            }
            return pen;
        }
    }
}
