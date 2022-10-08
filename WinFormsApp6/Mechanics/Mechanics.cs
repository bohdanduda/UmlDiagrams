namespace WinFormsApp6.Mechanics
{
    public class Mechanics
    {
        private int sampleClassNumber = 0;
        private const string SAMPLE_CLASS_NAME = "Class";
        Point newBoxSpawnPoint = new Point(100, 100);
        private const int SPAWN_POINT_OFFSET = 10;
        public List<ClassBox> ClassBoxes { get; set; } = new List<ClassBox>();

        public int Width { get; set; }

        public int Height { get; set; }

        public void Draw(Graphics g)
        {
            foreach (ClassBox item in ClassBoxes)
            {
                item.Draw(g);
            }
        }

        public void AddClassBox()
        {
            Point spawnPoint = generateNewClassSpawnPoint();

            ClassBoxes.Add(new ClassBox()
            {
                ClassData = new ClassData() { ClassName = generateNewClassName() },
                TopLeftPoint = spawnPoint,
                Width = 100,
                Height = 50
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
    }
}
