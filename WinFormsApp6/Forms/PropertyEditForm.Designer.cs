namespace WinFormsApp6
{
    partial class PropertyEditForm
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
            this.lbl_propertyName = new System.Windows.Forms.Label();
            this.txtBox_propertyName = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.comboBox_accessModifier = new System.Windows.Forms.ComboBox();
            this.comboBox_dataType = new System.Windows.Forms.ComboBox();
            this.lbl_accessModifier = new System.Windows.Forms.Label();
            this.lbl_dataType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_propertyName
            // 
            this.lbl_propertyName.AutoSize = true;
            this.lbl_propertyName.Location = new System.Drawing.Point(274, 26);
            this.lbl_propertyName.Name = "lbl_propertyName";
            this.lbl_propertyName.Size = new System.Drawing.Size(92, 15);
            this.lbl_propertyName.TabIndex = 0;
            this.lbl_propertyName.Text = "Název vlastnosti";
            // 
            // txtBox_propertyName
            // 
            this.txtBox_propertyName.Location = new System.Drawing.Point(251, 44);
            this.txtBox_propertyName.Name = "txtBox_propertyName";
            this.txtBox_propertyName.Size = new System.Drawing.Size(141, 23);
            this.txtBox_propertyName.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(118, 92);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "ULOŽIT";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(204, 92);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "STORNO";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // comboBox_accessModifier
            // 
            this.comboBox_accessModifier.FormattingEnabled = true;
            this.comboBox_accessModifier.Items.AddRange(new object[] {
            "public",
            "protected",
            "private"});
            this.comboBox_accessModifier.Location = new System.Drawing.Point(12, 44);
            this.comboBox_accessModifier.Name = "comboBox_accessModifier";
            this.comboBox_accessModifier.Size = new System.Drawing.Size(121, 23);
            this.comboBox_accessModifier.TabIndex = 4;
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
            this.comboBox_dataType.Location = new System.Drawing.Point(143, 44);
            this.comboBox_dataType.Name = "comboBox_dataType";
            this.comboBox_dataType.Size = new System.Drawing.Size(89, 23);
            this.comboBox_dataType.TabIndex = 5;
            // 
            // lbl_accessModifier
            // 
            this.lbl_accessModifier.AutoSize = true;
            this.lbl_accessModifier.Location = new System.Drawing.Point(17, 26);
            this.lbl_accessModifier.Name = "lbl_accessModifier";
            this.lbl_accessModifier.Size = new System.Drawing.Size(116, 15);
            this.lbl_accessModifier.TabIndex = 6;
            this.lbl_accessModifier.Text = "Modifikátor přístupu";
            // 
            // lbl_dataType
            // 
            this.lbl_dataType.AutoSize = true;
            this.lbl_dataType.Location = new System.Drawing.Point(149, 26);
            this.lbl_dataType.Name = "lbl_dataType";
            this.lbl_dataType.Size = new System.Drawing.Size(64, 15);
            this.lbl_dataType.TabIndex = 7;
            this.lbl_dataType.Text = "Datový typ";
            // 
            // PropertyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 127);
            this.Controls.Add(this.lbl_dataType);
            this.Controls.Add(this.lbl_accessModifier);
            this.Controls.Add(this.comboBox_dataType);
            this.Controls.Add(this.comboBox_accessModifier);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtBox_propertyName);
            this.Controls.Add(this.lbl_propertyName);
            this.Name = "PropertyEditForm";
            this.Text = "Editace vlastnosti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_propertyName;
        private TextBox txtBox_propertyName;
        private Button btn_save;
        private Button btn_cancel;
        private ComboBox comboBox_accessModifier;
        private ComboBox comboBox_dataType;
        private Label lbl_accessModifier;
        private Label lbl_dataType;
    }
}