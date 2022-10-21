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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_add_class = new System.Windows.Forms.Button();
            this.btn_removeClass = new System.Windows.Forms.Button();
            this.btn_SavePicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 408);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_add_class
            // 
            this.btn_add_class.Location = new System.Drawing.Point(12, 426);
            this.btn_add_class.Name = "btn_add_class";
            this.btn_add_class.Size = new System.Drawing.Size(90, 23);
            this.btn_add_class.TabIndex = 1;
            this.btn_add_class.Text = "PŘIDAT TŘÍDU";
            this.btn_add_class.UseVisualStyleBackColor = true;
            this.btn_add_class.Click += new System.EventHandler(this.btn_add_class_Click);
            // 
            // btn_removeClass
            // 
            this.btn_removeClass.Location = new System.Drawing.Point(108, 426);
            this.btn_removeClass.Name = "btn_removeClass";
            this.btn_removeClass.Size = new System.Drawing.Size(113, 23);
            this.btn_removeClass.TabIndex = 2;
            this.btn_removeClass.Text = "ODSTRANIT TŘÍDU";
            this.btn_removeClass.UseVisualStyleBackColor = true;
            this.btn_removeClass.Click += new System.EventHandler(this.btn_removeClass_Click);
            // 
            // btn_SavePicture
            // 
            this.btn_SavePicture.Location = new System.Drawing.Point(641, 426);
            this.btn_SavePicture.Name = "btn_SavePicture";
            this.btn_SavePicture.Size = new System.Drawing.Size(147, 23);
            this.btn_SavePicture.TabIndex = 3;
            this.btn_SavePicture.Text = "VYGENEROVAT OBRÁZEK";
            this.btn_SavePicture.UseVisualStyleBackColor = true;
            this.btn_SavePicture.Click += new System.EventHandler(this.btn_SavePicture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.btn_SavePicture);
            this.Controls.Add(this.btn_removeClass);
            this.Controls.Add(this.btn_add_class);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "UML diagram";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_add_class;
        private Button btn_removeClass;
        private Button btn_SavePicture;
    }
}