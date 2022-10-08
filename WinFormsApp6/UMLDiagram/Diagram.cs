using WinFormsApp6.Data;

namespace WinFormsApp6.UMLDiagram
{
    public class Diagram
    {
        private int sampleClassNumber = 0;
        private const string SAMPLE_CLASS_NAME = "Class";
        Point newBoxSpawnPoint = new Point(100, 100);
        private const int SPAWN_POINT_OFFSET = 10;
        public List<ClassBox> ClassBoxes { get; set; } = new List<ClassBox>();

        public void Draw(Graphics graphics)
        {
            foreach (ClassBox item in ClassBoxes)
            {
                item.Draw(graphics);
            }
        }

        public void AddClassBox()
        {
            this.ClassBoxes.Add(new ClassBox()
            {
                ClassData = new ClassData() { ClassName = this.generateNewClassName() },
                TopLeft = this.generateNewClassSpawnPoint(),
            });

        }

        private string generateNewClassName()
        {
            sampleClassNumber++;

            return SAMPLE_CLASS_NAME + sampleClassNumber.ToString();
        }


        private Point generateNewClassSpawnPoint()
        {
            newBoxSpawnPoint.X += SPAWN_POINT_OFFSET;
            newBoxSpawnPoint.Y += SPAWN_POINT_OFFSET;

            return new Point(newBoxSpawnPoint.X, newBoxSpawnPoint.Y);
        }

        public ClassBox? GetClickedClassBox(Point point)
        {
            for (int i = this.ClassBoxes.Count - 1; i >= 0; i--)
            {
                ClassBox classBox = this.ClassBoxes[i];

                if (classBox.IsPointInClassBox(point))
                {
                    this.ClassBoxes.Remove(classBox);
                    this.ClassBoxes.Add(classBox);

                    return classBox;
                }
            }

            return null;
        }
    }
}
