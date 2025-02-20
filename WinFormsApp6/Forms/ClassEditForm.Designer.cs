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
            txtBox_className = new TextBox();
            lbl_className = new Label();
            listBox_properties = new ListBox();
            lbl_properties = new Label();
            btn_save = new Button();
            btn_cancel = new Button();
            btn_delete_property = new Button();
            btn_add_property = new Button();
            btn_edit = new Button();
            btn_editMethod = new Button();
            btn_addNewMethod = new Button();
            btn_deleteMethod = new Button();
            lbl_methods = new Label();
            listBox_methods = new ListBox();
            checkBox_Interface = new CheckBox();
            btn_ChangeRelationship = new Button();
            lbl_Relationship = new Label();
            btn_addRelationship = new Button();
            btn_removeRelationship = new Button();
            listBox_Relationships = new ListBox();
            SuspendLayout();
            // 
            // txtBox_className
            // 
            txtBox_className.Location = new Point(278, 42);
            txtBox_className.Name = "txtBox_className";
            txtBox_className.Size = new Size(113, 23);
            txtBox_className.TabIndex = 1;
            // 
            // lbl_className
            // 
            lbl_className.AutoSize = true;
            lbl_className.Location = new Point(203, 45);
            lbl_className.Name = "lbl_className";
            lbl_className.Size = new Size(69, 15);
            lbl_className.TabIndex = 1;
            lbl_className.Text = "Název třídy:";
            // 
            // listBox_properties
            // 
            listBox_properties.FormattingEnabled = true;
            listBox_properties.Location = new Point(14, 99);
            listBox_properties.Name = "listBox_properties";
            listBox_properties.Size = new Size(174, 94);
            listBox_properties.TabIndex = 3;
            listBox_properties.DoubleClick += listBox_properties_DoubleClick;
            // 
            // lbl_properties
            // 
            lbl_properties.AutoSize = true;
            lbl_properties.Location = new Point(65, 81);
            lbl_properties.Name = "lbl_properties";
            lbl_properties.Size = new Size(61, 15);
            lbl_properties.TabIndex = 12;
            lbl_properties.Text = "Vlastnosti:";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(207, 331);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 15;
            btn_save.Text = "ULOŽIT";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(307, 331);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 16;
            btn_cancel.Text = "STORNO";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_delete_property
            // 
            btn_delete_property.Location = new Point(14, 199);
            btn_delete_property.Name = "btn_delete_property";
            btn_delete_property.Size = new Size(85, 23);
            btn_delete_property.TabIndex = 4;
            btn_delete_property.Text = "ODEBRAT";
            btn_delete_property.UseVisualStyleBackColor = true;
            btn_delete_property.Click += btn_delete_Click;
            // 
            // btn_add_property
            // 
            btn_add_property.Location = new Point(13, 228);
            btn_add_property.Name = "btn_add_property";
            btn_add_property.Size = new Size(175, 23);
            btn_add_property.TabIndex = 2;
            btn_add_property.Text = "PŘIDAT NOVOU VLASTNOST";
            btn_add_property.UseVisualStyleBackColor = true;
            btn_add_property.Click += btn_add_property_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(105, 199);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(83, 23);
            btn_edit.TabIndex = 5;
            btn_edit.Text = "UPRAVIT";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_editMethod
            // 
            btn_editMethod.Location = new Point(299, 199);
            btn_editMethod.Name = "btn_editMethod";
            btn_editMethod.Size = new Size(83, 23);
            btn_editMethod.TabIndex = 9;
            btn_editMethod.Text = "UPRAVIT";
            btn_editMethod.UseVisualStyleBackColor = true;
            btn_editMethod.Click += btn_editMethod_Click;
            // 
            // btn_addNewMethod
            // 
            btn_addNewMethod.Location = new Point(207, 228);
            btn_addNewMethod.Name = "btn_addNewMethod";
            btn_addNewMethod.Size = new Size(175, 23);
            btn_addNewMethod.TabIndex = 6;
            btn_addNewMethod.Text = "PŘIDAT NOVOU METODU";
            btn_addNewMethod.UseVisualStyleBackColor = true;
            btn_addNewMethod.Click += btn_addNewMethod_Click;
            // 
            // btn_deleteMethod
            // 
            btn_deleteMethod.Location = new Point(208, 199);
            btn_deleteMethod.Name = "btn_deleteMethod";
            btn_deleteMethod.Size = new Size(85, 23);
            btn_deleteMethod.TabIndex = 8;
            btn_deleteMethod.Text = "ODEBRAT";
            btn_deleteMethod.UseVisualStyleBackColor = true;
            btn_deleteMethod.Click += btn_deleteMethod_Click;
            // 
            // lbl_methods
            // 
            lbl_methods.AutoSize = true;
            lbl_methods.Location = new Point(265, 81);
            lbl_methods.Name = "lbl_methods";
            lbl_methods.Size = new Size(51, 15);
            lbl_methods.TabIndex = 20;
            lbl_methods.Text = "Metody:";
            lbl_methods.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox_methods
            // 
            listBox_methods.FormattingEnabled = true;
            listBox_methods.Location = new Point(208, 99);
            listBox_methods.Name = "listBox_methods";
            listBox_methods.Size = new Size(174, 94);
            listBox_methods.TabIndex = 7;
            listBox_methods.DoubleClick += listBox_methods_DoubleClick;
            // 
            // checkBox_Interface
            // 
            checkBox_Interface.AutoSize = true;
            checkBox_Interface.Location = new Point(253, 4);
            checkBox_Interface.Name = "checkBox_Interface";
            checkBox_Interface.Size = new Size(72, 19);
            checkBox_Interface.TabIndex = 14;
            checkBox_Interface.Text = "Rozhraní";
            checkBox_Interface.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeRelationship
            // 
            btn_ChangeRelationship.Location = new Point(497, 199);
            btn_ChangeRelationship.Name = "btn_ChangeRelationship";
            btn_ChangeRelationship.Size = new Size(83, 23);
            btn_ChangeRelationship.TabIndex = 13;
            btn_ChangeRelationship.Text = "UPRAVIT";
            btn_ChangeRelationship.UseVisualStyleBackColor = true;
            btn_ChangeRelationship.Click += btn_ChangeRelationship_Click;
            // 
            // lbl_Relationship
            // 
            lbl_Relationship.AutoSize = true;
            lbl_Relationship.Location = new Point(468, 81);
            lbl_Relationship.Name = "lbl_Relationship";
            lbl_Relationship.Size = new Size(45, 15);
            lbl_Relationship.TabIndex = 27;
            lbl_Relationship.Text = "Vztahy:";
            // 
            // btn_addRelationship
            // 
            btn_addRelationship.Location = new Point(405, 228);
            btn_addRelationship.Name = "btn_addRelationship";
            btn_addRelationship.Size = new Size(175, 23);
            btn_addRelationship.TabIndex = 10;
            btn_addRelationship.Text = "PŘIDAT NOVÝ VZTAH";
            btn_addRelationship.UseVisualStyleBackColor = true;
            btn_addRelationship.Click += btn_addRelationship_Click;
            // 
            // btn_removeRelationship
            // 
            btn_removeRelationship.Location = new Point(406, 199);
            btn_removeRelationship.Name = "btn_removeRelationship";
            btn_removeRelationship.Size = new Size(85, 23);
            btn_removeRelationship.TabIndex = 12;
            btn_removeRelationship.Text = "ODEBRAT";
            btn_removeRelationship.UseVisualStyleBackColor = true;
            btn_removeRelationship.Click += btn_removeRelationship_Click;
            // 
            // listBox_Relationships
            // 
            listBox_Relationships.FormattingEnabled = true;
            listBox_Relationships.Location = new Point(406, 99);
            listBox_Relationships.Name = "listBox_Relationships";
            listBox_Relationships.Size = new Size(174, 94);
            listBox_Relationships.TabIndex = 11;
            listBox_Relationships.DoubleClick += listBox_Relationships_DoubleClick;
            // 
            // ClassEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 367);
            Controls.Add(btn_addRelationship);
            Controls.Add(btn_removeRelationship);
            Controls.Add(listBox_Relationships);
            Controls.Add(lbl_Relationship);
            Controls.Add(btn_ChangeRelationship);
            Controls.Add(checkBox_Interface);
            Controls.Add(btn_editMethod);
            Controls.Add(btn_addNewMethod);
            Controls.Add(btn_deleteMethod);
            Controls.Add(lbl_methods);
            Controls.Add(listBox_methods);
            Controls.Add(btn_edit);
            Controls.Add(btn_add_property);
            Controls.Add(btn_delete_property);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(lbl_properties);
            Controls.Add(listBox_properties);
            Controls.Add(lbl_className);
            Controls.Add(txtBox_className);
            Name = "ClassEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editace třídy";
            ResumeLayout(false);
            PerformLayout();

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
        private Label lbl_Relationship;
        private Button btn_addRelationship;
        private Button btn_removeRelationship;
        private ListBox listBox_Relationships;
    }
}