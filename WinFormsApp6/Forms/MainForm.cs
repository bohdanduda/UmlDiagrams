using System;
using System.Text.Json;
using WinFormsApp6.Forms;
using WinFormsApp6.UMLDiagram;

namespace WinFormsApp6
{
    public partial class MainForm : Form
    {
        public Diagram Diagram { get; set; }
        public ClassBoxMover ClassBoxMover { get; set; }

        public MainForm()
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
                this.Diagram.UnsetSelectedClassbox();
                return;
            }
            this.Diagram.SetSelectedClassbox(classBox);
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

        public override void Refresh()
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
            ClassEditForm classEditForm = new ClassEditForm(classBox.ClassData, Diagram.GetClassNames());
            classEditForm.ShowDialog();
        }

        private void btn_removeClass_Click(object sender, EventArgs e)
        {
            if (this.Diagram.SelectedClassBox != null)
            {
                this.Diagram.ClassBoxes.Remove(Diagram.SelectedClassBox);
            }
        }

        private void btn_SavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Uložení diagramu jako obrázku",
                Filter = "formát JPG|*.jpg|formát BMP|*.bmp|formát GIF|*.gif|formát PNG|*.png"
            };
            saveFileDialog.ShowDialog();

            this.pictureBox1.Image.Save(saveFileDialog.FileName.ToString(), System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void btn_SaveDiagram_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Uložení diagramu do souboru JSON",
                Filter = "soubor JSON|*.json"
            };
            saveFileDialog.ShowDialog();

            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName.ToString());

            string jsonString = JsonSerializer.Serialize(this.Diagram);
            streamWriter.WriteLine(jsonString);
            streamWriter.Close();
        }

        private void btn_LoadDiagram_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Naètení diagramu ze souboru JSON",
                Filter = "soubor JSON|*.json"
            };
            openFileDialog.ShowDialog();

            StreamReader reader = new StreamReader(openFileDialog.OpenFile());

            try
            {
                Diagram? parsedDiagram = JsonSerializer.Deserialize<Diagram>(reader.ReadToEnd());
                if (parsedDiagram == null)
                {
                    throw new Exception("Naètený diagram je prázdný");
                }
                this.Diagram = parsedDiagram;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Nepodaøilo se naèíst diagram ze souboru.{Environment.NewLine} Chyba: {exception}");
            }
        }
    }
}