using WinFormsApp6.UMLDiagram;

namespace WinFormsApp6.Utils
{
    public class RelationshipJoinPointCalculator
    {
        public RelationshipLinePoints GetLinePoints(ClassBox sourceClassBox, ClassBox targetClassBox)
        {
            return new RelationshipLinePoints() {
                StartPoint = sourceClassBox.GetCenterPoint(),
                EndPoint = targetClassBox.GetCenterPoint()
                };
        }
    }
}
