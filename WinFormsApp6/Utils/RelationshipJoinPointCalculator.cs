using System.Runtime.InteropServices;
using WinFormsApp6.UMLDiagram;

namespace WinFormsApp6.Utils
{
    public class RelationshipJoinPointCalculator
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
        
        public RelationshipLinePoints GetLinePoints(ClassBox sourceClassBox, ClassBox targetClassBox, string strategy)
        {
            switch (strategy)
            {
                case LINE_TYPE_STRAIGHT:
                    return this.GetStraightLinePoints(sourceClassBox, targetClassBox);

                case LINE_TYPE_ORTHOGONAL:
                    return this.GetOrthogonalLinePoints(sourceClassBox, targetClassBox);

                default:
                    throw new Exception("Neplatný typ!");
            }
        }

        private RelationshipLinePoints GetStraightLinePoints(ClassBox sourceClassBox, ClassBox targetClassBox)
        {
            return new RelationshipLinePoints()
            {
                StartPoint = sourceClassBox.GetCenterPoint(),
                EndPoint = targetClassBox.GetCenterPoint()
            };
        }
       
        private RelationshipLinePoints GetOrthogonalLinePoints(ClassBox sourceClassBox, ClassBox targetClassBox)
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

            KeyValuePair<int, int> shortestDistance = new KeyValuePair<int, int>(0, joinPointDistances.Values.Max() +1);

            foreach (KeyValuePair <int, int> distance in joinPointDistances)
            {
                if (distance.Value<shortestDistance.Value)
                {
                    shortestDistance = distance;
                }
            }

            switch (shortestDistance.Key)
            {
                case BOTTOM_TO_LEFT:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetBottomJointPoint(),
                        EndPoint = targetClassBox.GetLeftJointPoint()
                    };

                case BOTTOM_TO_RIGHT:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetBottomJointPoint(),
                        EndPoint = targetClassBox.GetRightJointPoint()
                    };
                
                case BOTTOM_TO_TOP:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetBottomJointPoint(),
                        EndPoint = targetClassBox.GetTopJointPoint()
                    };

                case LEFT_TO_BOTTOM:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetLeftJointPoint(),
                        EndPoint = targetClassBox.GetBottomJointPoint()
                    };
                
                case LEFT_TO_RIGHT:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetLeftJointPoint(),
                        EndPoint = targetClassBox.GetRightJointPoint()
                    };

                case LEFT_TO_TOP:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetLeftJointPoint(),
                        EndPoint = targetClassBox.GetTopJointPoint()
                    };

                case RIGHT_TO_BOTTOM:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetRightJointPoint(),
                        EndPoint = targetClassBox.GetBottomJointPoint()
                    };

                case RIGHT_TO_LEFT:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetRightJointPoint(),
                        EndPoint = targetClassBox.GetLeftJointPoint()
                    };

                case RIGHT_TO_TOP:

                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetRightJointPoint(),
                        EndPoint = targetClassBox.GetTopJointPoint()
                    };

                case TOP_TO_BOTTOM:
                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetTopJointPoint(),
                        EndPoint = targetClassBox.GetBottomJointPoint()
                    };


                case TOP_TO_LEFT:
                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetTopJointPoint(),
                        EndPoint = targetClassBox.GetLeftJointPoint()
                    };


                case TOP_TO_RIGHT:
                    return new RelationshipLinePoints()
                    {
                        StartPoint = sourceClassBox.GetTopJointPoint(),
                        EndPoint = targetClassBox.GetRightJointPoint()
                    };

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
