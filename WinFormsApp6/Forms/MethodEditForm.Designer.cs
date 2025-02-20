namespace WinFormsApp6
{
    partial class MethodEditForm
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
            btn_cancel = new Button();
            btn_save = new Button();
            comboBox_accessModifier = new ComboBox();
            comboBox_dataType = new ComboBox();
            txtBox_methodName = new TextBox();
            lbl_accessModifier = new Label();
            lbl_datatype = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(215, 92);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "STORNO";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(126, 92);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 4;
            btn_save.Text = "ULOŽIT";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // comboBox_accessModifier
            // 
            comboBox_accessModifier.FormattingEnabled = true;
            comboBox_accessModifier.Items.AddRange(new object[] { "private", "protected", "public" });
            comboBox_accessModifier.Location = new Point(12, 48);
            comboBox_accessModifier.Name = "comboBox_accessModifier";
            comboBox_accessModifier.Size = new Size(121, 23);
            comboBox_accessModifier.TabIndex = 1;
            // 
            // comboBox_dataType
            // 
            comboBox_dataType.FormattingEnabled = true;
            comboBox_dataType.Items.AddRange(new object[] { "void", "int", "string", "double", "bool", "char" });
            comboBox_dataType.Location = new Point(139, 48);
            comboBox_dataType.Name = "comboBox_dataType";
            comboBox_dataType.Size = new Size(121, 23);
            comboBox_dataType.TabIndex = 2;
            // 
            // txtBox_methodName
            // 
            txtBox_methodName.Location = new Point(275, 48);
            txtBox_methodName.Name = "txtBox_methodName";
            txtBox_methodName.Size = new Size(115, 23);
            txtBox_methodName.TabIndex = 3;
            // 
            // lbl_accessModifier
            // 
            lbl_accessModifier.AutoSize = true;
            lbl_accessModifier.Location = new Point(12, 30);
            lbl_accessModifier.Name = "lbl_accessModifier";
            lbl_accessModifier.Size = new Size(116, 15);
            lbl_accessModifier.TabIndex = 5;
            lbl_accessModifier.Text = "Modifikátor přístupu";
            // 
            // lbl_datatype
            // 
            lbl_datatype.AutoSize = true;
            lbl_datatype.Location = new Point(166, 30);
            lbl_datatype.Name = "lbl_datatype";
            lbl_datatype.Size = new Size(64, 15);
            lbl_datatype.TabIndex = 6;
            lbl_datatype.Text = "Datový typ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 7;
            label1.Text = "Název metody";
            // 
            // MethodEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 134);
            Controls.Add(label1);
            Controls.Add(lbl_datatype);
            Controls.Add(lbl_accessModifier);
            Controls.Add(txtBox_methodName);
            Controls.Add(comboBox_dataType);
            Controls.Add(comboBox_accessModifier);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Name = "MethodEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editace metody";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private ComboBox comboBox_accessModifier;
        private ComboBox comboBox_dataType;
        private TextBox txtBox_methodName;
        private Label lbl_accessModifier;
        private Label lbl_datatype;
        private Label label1;
    }
}