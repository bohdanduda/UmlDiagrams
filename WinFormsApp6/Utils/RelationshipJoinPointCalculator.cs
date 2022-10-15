using WinFormsApp6.UMLDiagram;

namespace WinFormsApp6.Utils
{
    public class RelationshipJoinPointCalculator
    {
        public const string LINE_TYPE_STRAIGHT = "straight";

        public RelationshipLinePoints GetLinePoints(ClassBox sourceClassBox, ClassBox targetClassBox, string strategy)
        {
            switch (strategy)
            {
                case LINE_TYPE_STRAIGHT:
                    return this.GetStraightLinePoints(sourceClassBox, targetClassBox);
                    break;

                default:
                    throw new Exception("Neplatná strategie");
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
    }
}
