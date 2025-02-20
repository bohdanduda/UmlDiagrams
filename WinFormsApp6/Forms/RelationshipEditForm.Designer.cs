namespace WinFormsApp6.Forms
{
    partial class RelationshipEditForm
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
            lbl_dataType = new Label();
            lbl_Relationship = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            comboBox_Relationship = new ComboBox();
            comboBox_ClassName = new ComboBox();
            SuspendLayout();
            // 
            // lbl_dataType
            // 
            lbl_dataType.AutoSize = true;
            lbl_dataType.Location = new Point(180, 9);
            lbl_dataType.Name = "lbl_dataType";
            lbl_dataType.Size = new Size(41, 15);
            lbl_dataType.TabIndex = 11;
            lbl_dataType.Text = "K třídě";
            // 
            // lbl_Relationship
            // 
            lbl_Relationship.AutoSize = true;
            lbl_Relationship.Location = new Point(49, 9);
            lbl_Relationship.Name = "lbl_Relationship";
            lbl_Relationship.Size = new Size(36, 15);
            lbl_Relationship.TabIndex = 10;
            lbl_Relationship.Text = "Vztah";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(138, 68);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "STORNO";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(52, 68);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 3;
            btn_save.Text = "ULOŽIT";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // comboBox_Relationship
            // 
            comboBox_Relationship.FormattingEnabled = true;
            comboBox_Relationship.Location = new Point(6, 27);
            comboBox_Relationship.Name = "comboBox_Relationship";
            comboBox_Relationship.Size = new Size(121, 23);
            comboBox_Relationship.TabIndex = 1;
            // 
            // comboBox_ClassName
            // 
            comboBox_ClassName.FormattingEnabled = true;
            comboBox_ClassName.Location = new Point(138, 27);
            comboBox_ClassName.Name = "comboBox_ClassName";
            comboBox_ClassName.Size = new Size(121, 23);
            comboBox_ClassName.TabIndex = 2;
            // 
            // RelationshipEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 104);
            Controls.Add(comboBox_ClassName);
            Controls.Add(comboBox_Relationship);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(lbl_dataType);
            Controls.Add(lbl_Relationship);
            Name = "RelationshipEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editace vztahu";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lbl_dataType;
        private Label lbl_Relationship;
        private Button btn_cancel;
        private Button btn_save;
        private ComboBox comboBox_Relationship;
        private ComboBox comboBox_ClassName;
    }
}