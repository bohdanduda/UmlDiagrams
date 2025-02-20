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
            lbl_propertyName = new Label();
            txtBox_propertyName = new TextBox();
            btn_save = new Button();
            btn_cancel = new Button();
            comboBox_accessModifier = new ComboBox();
            comboBox_dataType = new ComboBox();
            lbl_accessModifier = new Label();
            lbl_dataType = new Label();
            SuspendLayout();
            // 
            // lbl_propertyName
            // 
            lbl_propertyName.AutoSize = true;
            lbl_propertyName.Location = new Point(274, 26);
            lbl_propertyName.Name = "lbl_propertyName";
            lbl_propertyName.Size = new Size(92, 15);
            lbl_propertyName.TabIndex = 0;
            lbl_propertyName.Text = "Název vlastnosti";
            // 
            // txtBox_propertyName
            // 
            txtBox_propertyName.Location = new Point(251, 44);
            txtBox_propertyName.Name = "txtBox_propertyName";
            txtBox_propertyName.Size = new Size(141, 23);
            txtBox_propertyName.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(118, 92);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 4;
            btn_save.Text = "ULOŽIT";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(204, 92);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "STORNO";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // comboBox_accessModifier
            // 
            comboBox_accessModifier.FormattingEnabled = true;
            comboBox_accessModifier.Items.AddRange(new object[] { "public", "protected", "private" });
            comboBox_accessModifier.Location = new Point(12, 44);
            comboBox_accessModifier.Name = "comboBox_accessModifier";
            comboBox_accessModifier.Size = new Size(121, 23);
            comboBox_accessModifier.TabIndex = 1;
            // 
            // comboBox_dataType
            // 
            comboBox_dataType.FormattingEnabled = true;
            comboBox_dataType.Items.AddRange(new object[] { "int", "string", "double", "bool", "char" });
            comboBox_dataType.Location = new Point(143, 44);
            comboBox_dataType.Name = "comboBox_dataType";
            comboBox_dataType.Size = new Size(89, 23);
            comboBox_dataType.TabIndex = 2;
            // 
            // lbl_accessModifier
            // 
            lbl_accessModifier.AutoSize = true;
            lbl_accessModifier.Location = new Point(17, 26);
            lbl_accessModifier.Name = "lbl_accessModifier";
            lbl_accessModifier.Size = new Size(116, 15);
            lbl_accessModifier.TabIndex = 6;
            lbl_accessModifier.Text = "Modifikátor přístupu";
            // 
            // lbl_dataType
            // 
            lbl_dataType.AutoSize = true;
            lbl_dataType.Location = new Point(149, 26);
            lbl_dataType.Name = "lbl_dataType";
            lbl_dataType.Size = new Size(64, 15);
            lbl_dataType.TabIndex = 7;
            lbl_dataType.Text = "Datový typ";
            // 
            // PropertyEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 127);
            Controls.Add(lbl_dataType);
            Controls.Add(lbl_accessModifier);
            Controls.Add(comboBox_dataType);
            Controls.Add(comboBox_accessModifier);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txtBox_propertyName);
            Controls.Add(lbl_propertyName);
            Name = "PropertyEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editace vlastnosti";
            ResumeLayout(false);
            PerformLayout();

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