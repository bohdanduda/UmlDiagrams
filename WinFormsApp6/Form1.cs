namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Mechanics.Mechanics Mechanics { get; set; }
        public Mechanics.MoveMechanics MoveMechanics { get; set; }

        public Form1()
        {
            InitializeComponent();

            this.Mechanics = new Mechanics.Mechanics() { Width = this.pictureBox1.Width, Height = this.pictureBox1.Height };
            this.MoveMechanics = new Mechanics.MoveMechanics();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.Mechanics.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }


        private void btn_add_class_Click(object sender, EventArgs e)
        {
            this.Mechanics.AddClassBox();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ClassBox? classBox = this.GetClickedClassBox(e.Location);
            if (classBox == null)
            {
                return;
            }
            MoveMechanics.StartMoving(classBox, e.Location);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveMechanics.StopMoving();
        }


        public ClassBox? GetClickedClassBox(Point point)
        {
            for (int i = this.Mechanics.ClassBoxes.Count - 1; i >= 0; i--)
            {
                ClassBox classBox = this.Mechanics.ClassBoxes[i];

                if (classBox.IsPointInClassBox(point))
                {
                    Mechanics.ClassBoxes.Remove(classBox);
                    Mechanics.ClassBoxes.Add(classBox);

                    return classBox;
                }
            }

            return null;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveMechanics.UpdateDiagram(e.Location);

        }

        public void Refresh()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            foreach (ClassBox classBox in Mechanics.ClassBoxes)
            {
                classBox.Draw(graphics);
            }
            
            pictureBox1.Image = bitmap;
        }
    }
}