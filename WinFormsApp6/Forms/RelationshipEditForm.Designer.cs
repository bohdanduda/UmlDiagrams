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
            this.lbl_dataType = new System.Windows.Forms.Label();
            this.lbl_Relationship = new System.Windows.Forms.Label();
            this.comboBox_dataType = new System.Windows.Forms.ComboBox();
            this.comboBox_accessModifier = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dataType
            // 
            this.lbl_dataType.AutoSize = true;
            this.lbl_dataType.Location = new System.Drawing.Point(180, 9);
            this.lbl_dataType.Name = "lbl_dataType";
            this.lbl_dataType.Size = new System.Drawing.Size(41, 15);
            this.lbl_dataType.TabIndex = 11;
            this.lbl_dataType.Text = "K třídě";
            // 
            // lbl_Relationship
            // 
            this.lbl_Relationship.AutoSize = true;
            this.lbl_Relationship.Location = new System.Drawing.Point(49, 9);
            this.lbl_Relationship.Name = "lbl_Relationship";
            this.lbl_Relationship.Size = new System.Drawing.Size(36, 15);
            this.lbl_Relationship.TabIndex = 10;
            this.lbl_Relationship.Text = "Vztah";
            // 
            // comboBox_dataType
            // 
            this.comboBox_dataType.FormattingEnabled = true;
            this.comboBox_dataType.Items.AddRange(new object[] {
            "int",
            "string",
            "double",
            "bool",
            "char"});
            this.comboBox_dataType.Location = new System.Drawing.Point(138, 27);
            this.comboBox_dataType.Name = "comboBox_dataType";
            this.comboBox_dataType.Size = new System.Drawing.Size(122, 23);
            this.comboBox_dataType.TabIndex = 9;
            // 
            // comboBox_accessModifier
            // 
            this.comboBox_accessModifier.FormattingEnabled = true;
            this.comboBox_accessModifier.Items.AddRange(new object[] {
            "public",
            "protected",
            "private"});
            this.comboBox_accessModifier.Location = new System.Drawing.Point(7, 27);
            this.comboBox_accessModifier.Name = "comboBox_accessModifier";
            this.comboBox_accessModifier.Size = new System.Drawing.Size(121, 23);
            this.comboBox_accessModifier.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(138, 68);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "STORNO";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(52, 68);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "ULOŽIT";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // RelationshipEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 104);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_dataType);
            this.Controls.Add(this.lbl_Relationship);
            this.Controls.Add(this.comboBox_dataType);
            this.Controls.Add(this.comboBox_accessModifier);
            this.Name = "RelationshipEditForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_dataType;
        private Label lbl_Relationship;
        private ComboBox comboBox_dataType;
        private ComboBox comboBox_accessModifier;
        private Button btn_cancel;
        private Button btn_save;
    }
}