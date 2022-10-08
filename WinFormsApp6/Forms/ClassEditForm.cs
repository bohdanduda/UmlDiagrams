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

            foreach (string propertyName in classData.Properties)
            {
                this.listBox_properties.Items.Add(propertyName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ClassData.ClassName = this.txtBox_className.Text;
            ClassData.Properties.Clear();
            foreach (string propertyName in listBox_properties.Items)
            {
                ClassData.Properties.Add(propertyName);
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
    }
}
