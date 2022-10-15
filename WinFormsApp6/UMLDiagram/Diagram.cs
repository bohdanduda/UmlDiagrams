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
        public ClassBox? SelectedClassBox;

        public void Draw(Graphics graphics)
        {

            foreach (ClassBox classbox in ClassBoxes)
            {
                classbox.DrawRelationships(graphics, GetRelatedClassBoxes(classbox.ClassData.Relationships));

            }

            foreach (ClassBox classbox in ClassBoxes)
            {
                classbox.Draw(graphics, SelectedClassBox == classbox, GetRelatedClassBoxes(classbox.ClassData.Relationships));
            }

        }

        public void AddClassBox()
        {
            ClassBox newClassBox = new ClassBox()
            {
                ClassData = new ClassData() { ClassName = this.generateNewClassName() },
                TopLeft = this.generateNewClassSpawnPoint(),
            };

            this.ClassBoxes.Add(newClassBox);
            this.SetSelectedClassbox(newClassBox);
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
        public void SetSelectedClassbox(ClassBox classbox)
        {
            this.SelectedClassBox = classbox;
        }

        public void UnsetSelectedClassbox()
        {
            this.SelectedClassBox = null;
        }

        public List<string> GetClassNames()
        {
            List<string> classNames = new List<string>();

            foreach (ClassBox classBox in this.ClassBoxes)
            {
                if (classBox.ClassData.ClassName != this.SelectedClassBox.ClassData.ClassName)
                {
                    classNames.Add(classBox.ClassData.ClassName);
                }
            }

            return classNames;
        }

        public List<ClassBox> GetRelatedClassBoxes(List<ClassRelationship> relationships)
        {
            List<ClassBox> relatedClassBoxes = new List<ClassBox>();
            foreach (ClassRelationship relationship in relationships)
            {
                relatedClassBoxes.Add(GetClassBoxForRelationship(relationship));
            }
            return relatedClassBoxes;
        }

        public ClassBox GetClassBoxForRelationship(ClassRelationship relationship)
        {
            foreach (ClassBox classBox in this.ClassBoxes)
            {
                if (classBox.ClassData.ClassName==relationship.RelatedClassName)
                {
                    return classBox;
                }
            }
            throw new Exception("Chybná data: Nenalezena třída s názvem");
        }
    }
}
