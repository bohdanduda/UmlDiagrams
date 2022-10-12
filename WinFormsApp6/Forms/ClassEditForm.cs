using WinFormsApp6.Data;
using WinFormsApp6.Forms;

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

            foreach (ClassMethod method in classData.Methods)
            {
                this.listBox_methods.Items.Add(method);
            }

            this.RefreshPropertyButtons();
            this.RefreshMethodButtons();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ClassData.ClassName = this.txtBox_className.Text;

            ClassData.Properties.Clear();
            foreach (ClassProperty property in listBox_properties.Items)
            {
                ClassData.Properties.Add(property);
            }

            ClassData.Methods.Clear();
            foreach (ClassMethod method in listBox_methods.Items)
            {
                ClassData.Methods.Add(method);
            }

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listBox_properties.SelectedItem == null)
            {
                MessageBox.Show("Je třeba vybrat vlastnost");
                return;
            }
            this.listBox_properties.Items.Remove(this.listBox_properties.SelectedItem);
            this.RefreshPropertyButtons();
        }

        private void btn_add_property_Click(object sender, EventArgs e)
        {
            PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, true);

            propertyEdit.ShowDialog();
            this.RefreshPropertyButtons();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (listBox_properties.SelectedItem == null)
            {
                MessageBox.Show("Je třeba vybrat vlastnost");
                return;
            }
            PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, false);

            propertyEdit.ShowDialog();
        }

        private void listBox_properties_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_properties.SelectedItem != null)
            {
                PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, false);
                propertyEdit.ShowDialog();
            }
        }

        private void btn_addNewMethod_Click(object sender, EventArgs e)
        {
            MethodEditForm methodEdit = new MethodEditForm(this.listBox_methods, true);
            methodEdit.ShowDialog();
            this.RefreshMethodButtons();
        }

        private void btn_editMethod_Click(object sender, EventArgs e)
        {
            if (listBox_methods.SelectedItem == null)
            {
                MessageBox.Show("Je třeba vybrat metodu");
                return;
            }

            MethodEditForm methodEdit = new MethodEditForm(this.listBox_methods, false);
            methodEdit.ShowDialog();
        }

        private void btn_deleteMethod_Click(object sender, EventArgs e)
        {
            if (listBox_methods.SelectedItem == null)
            {
                MessageBox.Show("Je třeba vybrat metodu");
                return;
            }

            this.listBox_methods.Items.Remove(this.listBox_methods.SelectedItem);
            this.RefreshMethodButtons();
        }

        private void RefreshPropertyButtons()
        {
            if (this.listBox_properties.Items.Count == 0)
            {
                this.btn_delete_property.Enabled = false;
                this.btn_edit.Enabled = false;

                return;
            }

            this.btn_delete_property.Enabled = true;
            this.btn_edit.Enabled = true;

        }

        private void RefreshMethodButtons()
        {
            if (this.listBox_methods.Items.Count == 0)
            {
                this.btn_deleteMethod.Enabled = false;
                this.btn_editMethod.Enabled = false;

                return;
            }

            this.btn_deleteMethod.Enabled = true;
            this.btn_editMethod.Enabled = true;

        }

        private void listBox_methods_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_methods.SelectedItem != null)
            {
                MethodEditForm methodEditForm = new MethodEditForm(this.listBox_methods, false);
                methodEditForm.ShowDialog();
            }
        }

        private void checkBox_Interface_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Interface.Checked)
            {
                this.ClassData.IsInterface = true;
                MessageBox.Show("Jeník");
            }

        }

        private void btn_ChangeRelationship_Click(object sender, EventArgs e)
        {
            RelationshipEditForm relationshipEditForm = new RelationshipEditForm();
            relationshipEditForm.ShowDialog();

            this.txtBox_CurrentRelationship.Text = "Jeník";
        }
    }
}
