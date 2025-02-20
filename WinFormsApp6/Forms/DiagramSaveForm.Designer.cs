namespace WinFormsApp6.Forms
{
    partial class DiagramSaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Path = new Label();
            btn_OpenExplorer = new Button();
            txtBox_PathName = new TextBox();
            btn_Save = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // lbl_Path
            // 
            lbl_Path.AutoSize = true;
            lbl_Path.Location = new Point(14, 16);
            lbl_Path.Name = "lbl_Path";
            lbl_Path.Size = new Size(39, 15);
            lbl_Path.TabIndex = 2;
            lbl_Path.Text = "Cesta:";
            // 
            // btn_OpenExplorer
            // 
            btn_OpenExplorer.Location = new Point(440, 12);
            btn_OpenExplorer.Name = "btn_OpenExplorer";
            btn_OpenExplorer.Size = new Size(75, 23);
            btn_OpenExplorer.TabIndex = 3;
            btn_OpenExplorer.Text = "Otevřít";
            btn_OpenExplorer.UseVisualStyleBackColor = true;
            btn_OpenExplorer.Click += btn_OpenExplorer_Click;
            // 
            // txtBox_PathName
            // 
            txtBox_PathName.Location = new Point(59, 12);
            txtBox_PathName.Name = "txtBox_PathName";
            txtBox_PathName.Size = new Size(375, 23);
            txtBox_PathName.TabIndex = 4;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(171, 59);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "ULOŽIT";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(252, 59);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "STORNO";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // DiagramSaveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 94);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(txtBox_PathName);
            Controls.Add(btn_OpenExplorer);
            Controls.Add(lbl_Path);
            Name = "DiagramSaveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiagramSaveForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label lbl_Path;
        private Button btn_OpenExplorer;
        private TextBox txtBox_PathName;
        private Button btn_Save;
        private Button btn_Cancel;
    }
}