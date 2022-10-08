using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp6.Data;

namespace WinFormsApp6
{
    public partial class ClassEditForm : Form
    {
        public ClassData ClassData { get; set; }
        public ClassEditForm(ClassData classData)
        {
            InitializeComponent();
            this.ClassData = classData;
            this.txtBox_className.Text = classData.ClassName;

            foreach (ClassProperty property in classData.Properties)
            {
                this.listBox_properties.Items.Add(property);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ClassData.ClassName = this.txtBox_className.Text;
            ClassData.Properties.Clear();
            foreach (ClassProperty property in listBox_properties.Items)
            {
                ClassData.Properties.Add(property);
            }
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.listBox_properties.Items.Remove(this.listBox_properties.SelectedItem);
        }

        private void btn_add_property_Click(object sender, EventArgs e)
        {
            PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, true);

            propertyEdit.Show();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (listBox_properties.SelectedItem==null)
            {
                MessageBox.Show("Je třeba vybrat vlastnost");
                return;
            }
            PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, false);

            propertyEdit.Show();
        }

        private void listBox_properties_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_properties.SelectedItem != null)
            {
                PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, false);
                propertyEdit.Show();
            }
        }
    }
}
