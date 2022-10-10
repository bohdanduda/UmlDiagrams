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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.comboBox_accessModifier = new System.Windows.Forms.ComboBox();
            this.comboBox_dataType = new System.Windows.Forms.ComboBox();
            this.txtBox_methodName = new System.Windows.Forms.TextBox();
            this.lbl_accessModifier = new System.Windows.Forms.Label();
            this.lbl_datatype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(230, 92);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "STORNO";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(116, 92);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "ULOŽIT";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // comboBox_accessModifier
            // 
            this.comboBox_accessModifier.FormattingEnabled = true;
            this.comboBox_accessModifier.Items.AddRange(new object[] {
            "public",
            "protected",
            "private"});
            this.comboBox_accessModifier.Location = new System.Drawing.Point(12, 48);
            this.comboBox_accessModifier.Name = "comboBox_accessModifier";
            this.comboBox_accessModifier.Size = new System.Drawing.Size(121, 23);
            this.comboBox_accessModifier.TabIndex = 2;
            // 
            // comboBox_dataType
            // 
            this.comboBox_dataType.FormattingEnabled = true;
            this.comboBox_dataType.Items.AddRange(new object[] {
            "void",
            "int",
            "string",
            "double",
            "bool",
            "char"});
            this.comboBox_dataType.Location = new System.Drawing.Point(139, 48);
            this.comboBox_dataType.Name = "comboBox_dataType";
            this.comboBox_dataType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_dataType.TabIndex = 3;
            // 
            // txtBox_methodName
            // 
            this.txtBox_methodName.Location = new System.Drawing.Point(275, 48);
            this.txtBox_methodName.Name = "txtBox_methodName";
            this.txtBox_methodName.Size = new System.Drawing.Size(115, 23);
            this.txtBox_methodName.TabIndex = 4;
            // 
            // lbl_accessModifier
            // 
            this.lbl_accessModifier.AutoSize = true;
            this.lbl_accessModifier.Location = new System.Drawing.Point(12, 30);
            this.lbl_accessModifier.Name = "lbl_accessModifier";
            this.lbl_accessModifier.Size = new System.Drawing.Size(116, 15);
            this.lbl_accessModifier.TabIndex = 5;
            this.lbl_accessModifier.Text = "Modifikátor přístupu";
            // 
            // lbl_datatype
            // 
            this.lbl_datatype.AutoSize = true;
            this.lbl_datatype.Location = new System.Drawing.Point(166, 30);
            this.lbl_datatype.Name = "lbl_datatype";
            this.lbl_datatype.Size = new System.Drawing.Size(64, 15);
            this.lbl_datatype.TabIndex = 6;
            this.lbl_datatype.Text = "Datový typ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Název metody";
            // 
            // MethodEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 134);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_datatype);
            this.Controls.Add(this.lbl_accessModifier);
            this.Controls.Add(this.txtBox_methodName);
            this.Controls.Add(this.comboBox_dataType);
            this.Controls.Add(this.comboBox_accessModifier);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Name = "MethodEditForm";
            this.Text = "Editace metody";
            this.ResumeLayout(false);
            this.PerformLayout();

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