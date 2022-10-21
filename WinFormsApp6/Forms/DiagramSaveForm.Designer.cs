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
            this.lbl_Path = new System.Windows.Forms.Label();
            this.btn_OpenExplorer = new System.Windows.Forms.Button();
            this.txtBox_PathName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Location = new System.Drawing.Point(14, 16);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(39, 15);
            this.lbl_Path.TabIndex = 2;
            this.lbl_Path.Text = "Cesta:";
            // 
            // btn_OpenExplorer
            // 
            this.btn_OpenExplorer.Location = new System.Drawing.Point(440, 12);
            this.btn_OpenExplorer.Name = "btn_OpenExplorer";
            this.btn_OpenExplorer.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenExplorer.TabIndex = 3;
            this.btn_OpenExplorer.Text = "Otevřít";
            this.btn_OpenExplorer.UseVisualStyleBackColor = true;
            this.btn_OpenExplorer.Click += new System.EventHandler(this.btn_OpenExplorer_Click);
            // 
            // txtBox_PathName
            // 
            this.txtBox_PathName.Location = new System.Drawing.Point(59, 12);
            this.txtBox_PathName.Name = "txtBox_PathName";
            this.txtBox_PathName.Size = new System.Drawing.Size(375, 23);
            this.txtBox_PathName.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(171, 59);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "ULOŽIT";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(252, 59);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "STORNO";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DiagramSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 94);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtBox_PathName);
            this.Controls.Add(this.btn_OpenExplorer);
            this.Controls.Add(this.lbl_Path);
            this.Name = "DiagramSaveForm";
            this.Text = "DiagramSaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Path;
        private Button btn_OpenExplorer;
        private TextBox txtBox_PathName;
        private Button btn_Save;
        private Button btn_Cancel;
    }
}