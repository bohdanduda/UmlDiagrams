namespace WinFormsApp6
{
    partial class ClassEditForm
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
            this.txtBox_className = new System.Windows.Forms.TextBox();
            this.lbl_className = new System.Windows.Forms.Label();
            this.listBox_properties = new System.Windows.Forms.ListBox();
            this.lbl_properties = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete_property = new System.Windows.Forms.Button();
            this.btn_add_property = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_className
            // 
            this.txtBox_className.Location = new System.Drawing.Point(86, 15);
            this.txtBox_className.Name = "txtBox_className";
            this.txtBox_className.Size = new System.Drawing.Size(100, 23);
            this.txtBox_className.TabIndex = 0;
            // 
            // lbl_className
            // 
            this.lbl_className.AutoSize = true;
            this.lbl_className.Location = new System.Drawing.Point(11, 18);
            this.lbl_className.Name = "lbl_className";
            this.lbl_className.Size = new System.Drawing.Size(69, 15);
            this.lbl_className.TabIndex = 1;
            this.lbl_className.Text = "Název třídy:";
            // 
            // listBox_properties
            // 
            this.listBox_properties.FormattingEnabled = true;
            this.listBox_properties.ItemHeight = 15;
            this.listBox_properties.Location = new System.Drawing.Point(12, 85);
            this.listBox_properties.Name = "listBox_properties";
            this.listBox_properties.Size = new System.Drawing.Size(142, 94);
            this.listBox_properties.TabIndex = 10;
            // 
            // lbl_properties
            // 
            this.lbl_properties.AutoSize = true;
            this.lbl_properties.Location = new System.Drawing.Point(51, 67);
            this.lbl_properties.Name = "lbl_properties";
            this.lbl_properties.Size = new System.Drawing.Size(61, 15);
            this.lbl_properties.TabIndex = 12;
            this.lbl_properties.Text = "Vlastnosti:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 250);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "ULOŽIT";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(93, 250);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "STORNO";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete_property
            // 
            this.btn_delete_property.Location = new System.Drawing.Point(12, 185);
            this.btn_delete_property.Name = "btn_delete_property";
            this.btn_delete_property.Size = new System.Drawing.Size(68, 23);
            this.btn_delete_property.TabIndex = 16;
            this.btn_delete_property.Text = "ODEBRAT";
            this.btn_delete_property.UseVisualStyleBackColor = true;
            this.btn_delete_property.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add_property
            // 
            this.btn_add_property.Location = new System.Drawing.Point(86, 185);
            this.btn_add_property.Name = "btn_add_property";
            this.btn_add_property.Size = new System.Drawing.Size(68, 23);
            this.btn_add_property.TabIndex = 17;
            this.btn_add_property.Text = "PŘIDAT";
            this.btn_add_property.UseVisualStyleBackColor = true;
            this.btn_add_property.Click += new System.EventHandler(this.btn_add_property_Click);
            // 
            // ClassEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 328);
            this.Controls.Add(this.btn_add_property);
            this.Controls.Add(this.btn_delete_property);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_properties);
            this.Controls.Add(this.listBox_properties);
            this.Controls.Add(this.lbl_className);
            this.Controls.Add(this.txtBox_className);
            this.Name = "ClassEditForm";
            this.Text = "Editace třídy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBox_className;
        private Label lbl_className;
        private ListBox listBox_properties;
        private Label lbl_properties;
        private Button btn_save;
        private Button btn_cancel;
        private Button btn_delete_property;
        private Button btn_add_property;
    }
}