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
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_editMethod = new System.Windows.Forms.Button();
            this.btn_addNewMethod = new System.Windows.Forms.Button();
            this.btn_deleteMethod = new System.Windows.Forms.Button();
            this.lbl_methods = new System.Windows.Forms.Label();
            this.listBox_methods = new System.Windows.Forms.ListBox();
            this.checkBox_Interface = new System.Windows.Forms.CheckBox();
            this.btn_ChangeRelationship = new System.Windows.Forms.Button();
            this.txtBox_CurrentRelationship = new System.Windows.Forms.TextBox();
            this.lbl_Relationship = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_className
            // 
            this.txtBox_className.Location = new System.Drawing.Point(180, 48);
            this.txtBox_className.Name = "txtBox_className";
            this.txtBox_className.Size = new System.Drawing.Size(113, 23);
            this.txtBox_className.TabIndex = 0;
            // 
            // lbl_className
            // 
            this.lbl_className.AutoSize = true;
            this.lbl_className.Location = new System.Drawing.Point(105, 51);
            this.lbl_className.Name = "lbl_className";
            this.lbl_className.Size = new System.Drawing.Size(69, 15);
            this.lbl_className.TabIndex = 1;
            this.lbl_className.Text = "Název třídy:";
            // 
            // listBox_properties
            // 
            this.listBox_properties.FormattingEnabled = true;
            this.listBox_properties.ItemHeight = 15;
            this.listBox_properties.Location = new System.Drawing.Point(14, 99);
            this.listBox_properties.Name = "listBox_properties";
            this.listBox_properties.Size = new System.Drawing.Size(174, 94);
            this.listBox_properties.TabIndex = 10;
            this.listBox_properties.DoubleClick += new System.EventHandler(this.listBox_properties_DoubleClick);
            // 
            // lbl_properties
            // 
            this.lbl_properties.AutoSize = true;
            this.lbl_properties.Location = new System.Drawing.Point(65, 81);
            this.lbl_properties.Name = "lbl_properties";
            this.lbl_properties.Size = new System.Drawing.Size(61, 15);
            this.lbl_properties.TabIndex = 12;
            this.lbl_properties.Text = "Vlastnosti:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(113, 389);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "ULOŽIT";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(208, 389);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "STORNO";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete_property
            // 
            this.btn_delete_property.Location = new System.Drawing.Point(14, 199);
            this.btn_delete_property.Name = "btn_delete_property";
            this.btn_delete_property.Size = new System.Drawing.Size(85, 23);
            this.btn_delete_property.TabIndex = 16;
            this.btn_delete_property.Text = "ODEBRAT";
            this.btn_delete_property.UseVisualStyleBackColor = true;
            this.btn_delete_property.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add_property
            // 
            this.btn_add_property.Location = new System.Drawing.Point(13, 228);
            this.btn_add_property.Name = "btn_add_property";
            this.btn_add_property.Size = new System.Drawing.Size(175, 23);
            this.btn_add_property.TabIndex = 17;
            this.btn_add_property.Text = "PŘIDAT NOVOU VLASTNOST";
            this.btn_add_property.UseVisualStyleBackColor = true;
            this.btn_add_property.Click += new System.EventHandler(this.btn_add_property_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(105, 199);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(83, 23);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "UPRAVIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_editMethod
            // 
            this.btn_editMethod.Location = new System.Drawing.Point(299, 199);
            this.btn_editMethod.Name = "btn_editMethod";
            this.btn_editMethod.Size = new System.Drawing.Size(83, 23);
            this.btn_editMethod.TabIndex = 23;
            this.btn_editMethod.Text = "UPRAVIT";
            this.btn_editMethod.UseVisualStyleBackColor = true;
            this.btn_editMethod.Click += new System.EventHandler(this.btn_editMethod_Click);
            // 
            // btn_addNewMethod
            // 
            this.btn_addNewMethod.Location = new System.Drawing.Point(207, 228);
            this.btn_addNewMethod.Name = "btn_addNewMethod";
            this.btn_addNewMethod.Size = new System.Drawing.Size(175, 23);
            this.btn_addNewMethod.TabIndex = 22;
            this.btn_addNewMethod.Text = "PŘIDAT NOVOU METODU";
            this.btn_addNewMethod.UseVisualStyleBackColor = true;
            this.btn_addNewMethod.Click += new System.EventHandler(this.btn_addNewMethod_Click);
            // 
            // btn_deleteMethod
            // 
            this.btn_deleteMethod.Location = new System.Drawing.Point(208, 199);
            this.btn_deleteMethod.Name = "btn_deleteMethod";
            this.btn_deleteMethod.Size = new System.Drawing.Size(85, 23);
            this.btn_deleteMethod.TabIndex = 21;
            this.btn_deleteMethod.Text = "ODEBRAT";
            this.btn_deleteMethod.UseVisualStyleBackColor = true;
            this.btn_deleteMethod.Click += new System.EventHandler(this.btn_deleteMethod_Click);
            // 
            // lbl_methods
            // 
            this.lbl_methods.AutoSize = true;
            this.lbl_methods.Location = new System.Drawing.Point(265, 81);
            this.lbl_methods.Name = "lbl_methods";
            this.lbl_methods.Size = new System.Drawing.Size(51, 15);
            this.lbl_methods.TabIndex = 20;
            this.lbl_methods.Text = "Metody:";
            this.lbl_methods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox_methods
            // 
            this.listBox_methods.FormattingEnabled = true;
            this.listBox_methods.ItemHeight = 15;
            this.listBox_methods.Location = new System.Drawing.Point(208, 99);
            this.listBox_methods.Name = "listBox_methods";
            this.listBox_methods.Size = new System.Drawing.Size(174, 94);
            this.listBox_methods.TabIndex = 19;
            this.listBox_methods.DoubleClick += new System.EventHandler(this.listBox_methods_DoubleClick);
            // 
            // checkBox_Interface
            // 
            this.checkBox_Interface.AutoSize = true;
            this.checkBox_Interface.Location = new System.Drawing.Point(155, 10);
            this.checkBox_Interface.Name = "checkBox_Interface";
            this.checkBox_Interface.Size = new System.Drawing.Size(72, 19);
            this.checkBox_Interface.TabIndex = 24;
            this.checkBox_Interface.Text = "Rozhraní";
            this.checkBox_Interface.UseVisualStyleBackColor = true;
            this.checkBox_Interface.CheckedChanged += new System.EventHandler(this.checkBox_Interface_CheckedChanged);
            // 
            // btn_ChangeRelationship
            // 
            this.btn_ChangeRelationship.Location = new System.Drawing.Point(82, 299);
            this.btn_ChangeRelationship.Name = "btn_ChangeRelationship";
            this.btn_ChangeRelationship.Size = new System.Drawing.Size(106, 23);
            this.btn_ChangeRelationship.TabIndex = 25;
            this.btn_ChangeRelationship.Text = "ZMĚNIT VZTAH";
            this.btn_ChangeRelationship.UseVisualStyleBackColor = true;
            this.btn_ChangeRelationship.Click += new System.EventHandler(this.btn_ChangeRelationship_Click);
            // 
            // txtBox_CurrentRelationship
            // 
            this.txtBox_CurrentRelationship.Location = new System.Drawing.Point(194, 299);
            this.txtBox_CurrentRelationship.Name = "txtBox_CurrentRelationship";
            this.txtBox_CurrentRelationship.Size = new System.Drawing.Size(99, 23);
            this.txtBox_CurrentRelationship.TabIndex = 26;
            // 
            // lbl_Relationship
            // 
            this.lbl_Relationship.AutoSize = true;
            this.lbl_Relationship.Location = new System.Drawing.Point(198, 281);
            this.lbl_Relationship.Name = "lbl_Relationship";
            this.lbl_Relationship.Size = new System.Drawing.Size(85, 15);
            this.lbl_Relationship.TabIndex = 27;
            this.lbl_Relationship.Text = "Aktuální vztah:";
            // 
            // ClassEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 424);
            this.Controls.Add(this.lbl_Relationship);
            this.Controls.Add(this.txtBox_CurrentRelationship);
            this.Controls.Add(this.btn_ChangeRelationship);
            this.Controls.Add(this.checkBox_Interface);
            this.Controls.Add(this.btn_editMethod);
            this.Controls.Add(this.btn_addNewMethod);
            this.Controls.Add(this.btn_deleteMethod);
            this.Controls.Add(this.lbl_methods);
            this.Controls.Add(this.listBox_methods);
            this.Controls.Add(this.btn_edit);
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
        private Button btn_edit;
        private Button btn_editMethod;
        private Button btn_addNewMethod;
        private Button btn_deleteMethod;
        private Label lbl_methods;
        private ListBox listBox_methods;
        private CheckBox checkBox_Interface;
        private Button btn_ChangeRelationship;
        private TextBox txtBox_CurrentRelationship;
        private Label lbl_Relationship;
    }
}