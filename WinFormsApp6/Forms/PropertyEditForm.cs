using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                this.txtBox_propertyName.Text = propertyListBox.SelectedItem.ToString();
            }
            else
            {
                this.Text = "Přidání nové vlastnosti";
                this.Update();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.addingNewProperty)
            {
                this.PropertyListBox.Items.Add(this.txtBox_propertyName.Text);
            }
            
            this.PropertyListBox.Items[this.PropertyListBox.SelectedIndex] = this.txtBox_propertyName.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
