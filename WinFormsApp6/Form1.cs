using WinFormsApp6.Data;
using WinFormsApp6.UMLDiagram;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Diagram Diagram { get; set; }
        public ClassBoxMover ClassBoxMover { get; set; }

        public Form1()
        {
            InitializeComponent();

            this.Diagram = new Diagram();
            this.ClassBoxMover = new ClassBoxMover();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.Diagram.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            this.Diagram.AddClassBox();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ClassBox? classBox = this.Diagram.GetClickedClassBox(e.Location);
            if (classBox == null)
            {
                return;
            }
            ClassBoxMover.StartMoving(classBox, e.Location);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ClassBoxMover.StopMoving();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ClassBoxMover.UpdateDiagram(e.Location);

        }

        public void Refresh()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            this.Diagram.Draw(graphics);    
            
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClassBox? classBox = this.Diagram.GetClickedClassBox(e.Location);
            if (classBox == null)
            {
                return;
            }
            Form2 form2 = new Form2(classBox.ClassData); 
            form2.Show();
        }
    }
}