namespace WinFormsApp6
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_add_class = new Button();
            btn_removeClass = new Button();
            btn_SavePicture = new Button();
            btn_SaveDiagram = new Button();
            btn_LoadDiagram = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 408);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDoubleClick += pictureBox1_MouseDoubleClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // btn_add_class
            // 
            btn_add_class.Location = new Point(12, 426);
            btn_add_class.Name = "btn_add_class";
            btn_add_class.Size = new Size(90, 23);
            btn_add_class.TabIndex = 1;
            btn_add_class.Text = "PŘIDAT TŘÍDU";
            btn_add_class.UseVisualStyleBackColor = true;
            btn_add_class.Click += btn_add_class_Click;
            // 
            // btn_removeClass
            // 
            btn_removeClass.Location = new Point(108, 426);
            btn_removeClass.Name = "btn_removeClass";
            btn_removeClass.Size = new Size(113, 23);
            btn_removeClass.TabIndex = 2;
            btn_removeClass.Text = "ODSTRANIT TŘÍDU";
            btn_removeClass.UseVisualStyleBackColor = true;
            btn_removeClass.Click += btn_removeClass_Click;
            // 
            // btn_SavePicture
            // 
            btn_SavePicture.Location = new Point(641, 426);
            btn_SavePicture.Name = "btn_SavePicture";
            btn_SavePicture.Size = new Size(147, 23);
            btn_SavePicture.TabIndex = 3;
            btn_SavePicture.Text = "VYGENEROVAT OBRÁZEK";
            btn_SavePicture.UseVisualStyleBackColor = true;
            btn_SavePicture.Click += btn_SavePicture_Click;
            // 
            // btn_SaveDiagram
            // 
            btn_SaveDiagram.Location = new Point(337, 426);
            btn_SaveDiagram.Name = "btn_SaveDiagram";
            btn_SaveDiagram.Size = new Size(75, 23);
            btn_SaveDiagram.TabIndex = 4;
            btn_SaveDiagram.Text = "ULOŽIT";
            btn_SaveDiagram.UseVisualStyleBackColor = true;
            btn_SaveDiagram.Click += btn_SaveDiagram_Click;
            // 
            // btn_LoadDiagram
            // 
            btn_LoadDiagram.Location = new Point(418, 426);
            btn_LoadDiagram.Name = "btn_LoadDiagram";
            btn_LoadDiagram.Size = new Size(75, 23);
            btn_LoadDiagram.TabIndex = 5;
            btn_LoadDiagram.Text = "NAČÍST";
            btn_LoadDiagram.UseVisualStyleBackColor = true;
            btn_LoadDiagram.Click += btn_LoadDiagram_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 459);
            Controls.Add(btn_LoadDiagram);
            Controls.Add(btn_SaveDiagram);
            Controls.Add(btn_SavePicture);
            Controls.Add(btn_removeClass);
            Controls.Add(btn_add_class);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UML diagram";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_add_class;
        private Button btn_removeClass;
        private Button btn_SavePicture;
        private Button btn_SaveDiagram;
        private Button btn_LoadDiagram;
    }
}