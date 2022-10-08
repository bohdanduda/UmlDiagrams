﻿using WinFormsApp6.Data;

namespace WinFormsApp6
{
    public partial class PropertyEditForm : Form
    {
        private bool addingNewProperty { get; set; }
        public ListBox PropertyListBox { get; set; }
        public PropertyEditForm(ListBox propertyListBox, bool addingNewProperty)
        {
            PropertyListBox = propertyListBox;
            this.addingNewProperty = addingNewProperty;
            InitializeComponent();
            if (!addingNewProperty)
            {
                ClassProperty selectedProperty = this.PropertyListBox.SelectedItem as ClassProperty;
                this.txtBox_propertyName.Text = selectedProperty.Name;
            }
            else
            {
                this.Text = "Přidání nové vlastnosti";
                this.Update();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (comboBox_accessModifier.SelectedItem==null)
            {
                MessageBox.Show("Je třeba vybrat modifikátor přístupu!");
                return;
            }

            if (comboBox_dataType.SelectedItem==null)
            {
                MessageBox.Show("Je třeba vybrat datový typ!");
                return;
            }

            if (txtBox_propertyName.Text.Trim()=="")
            {
                MessageBox.Show("Název vlastnosti nesmí být prázdný!");
                return;
            }

            if (this.addingNewProperty)
            {
                this.PropertyListBox.Items.Add(new ClassProperty() { Name = this.txtBox_propertyName.Text });
                this.Close();

                return;
            }

            ClassProperty selectedProperty = this.PropertyListBox.SelectedItem as ClassProperty;
            selectedProperty.Name = this.txtBox_propertyName.Text;
            this.PropertyListBox.Update();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
