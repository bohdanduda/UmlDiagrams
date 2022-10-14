using System.Runtime.CompilerServices;
using WinFormsApp6.Data;
using WinFormsApp6.Forms;
using WinFormsApp6.UMLDiagram;
using WinFormsApp6.Utils;

namespace WinFormsApp6
{
    public partial class ClassEditForm : Form
    {
        public ClassData ClassData { get; set; }
        public TextValidator TextValidator = new TextValidator();

        public List<string> ClassNames = new();

        public ClassEditForm(ClassData classData, List<string> classNames)
        {
            InitializeComponent();
            this.ClassData = classData;
            this.txtBox_className.Text = classData.ClassName;
            this.ClassNames = classNames;

            if (this.ClassData.IsInterface)
            {
                this.checkBox_Interface.CheckState = CheckState.Checked;
            }

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
            MainForm mainForm = new MainForm();
            if (!this.CheckClassName())
            {
                return;
            }
            
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
            
            mainForm.Refresh();
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
            PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, this.GetPropertyNames(), true);

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
            PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, this.GetPropertyNames(), false);

            propertyEdit.ShowDialog();
        }

        private void listBox_properties_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_properties.SelectedItem != null)
            {
                PropertyEditForm propertyEdit = new PropertyEditForm(listBox_properties, this.GetPropertyNames(), false);
                propertyEdit.ShowDialog();
            }
        }

        private void btn_addNewMethod_Click(object sender, EventArgs e)
        {
            MethodEditForm methodEdit = new MethodEditForm(this.listBox_methods, this.GetMethodNames(), true);
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

            MethodEditForm methodEdit = new MethodEditForm(this.listBox_methods, this.GetMethodNames(), false);
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
                MethodEditForm methodEditForm = new MethodEditForm(this.listBox_methods, this.GetMethodNames(), false);
                methodEditForm.ShowDialog();
            }
        }

        private void checkBox_Interface_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Interface.Checked)
            {
                this.ClassData.IsInterface = true;
            }
            else
            {
                this.ClassData.IsInterface = false;
            }
        }

        private void btn_ChangeRelationship_Click(object sender, EventArgs e)
        {
            RelationshipEditForm relationshipEditForm = new RelationshipEditForm(this.ClassNames);
            relationshipEditForm.ShowDialog();
        }

        private bool CheckClassName()
        {
            if (!TextValidator.ValidateText(this.txtBox_className.Text))
            {
                MessageBox.Show("Neplatný název třídy!");
                
                return false;
            }
            if (!TextValidator.ValidateUniqueName(this.ClassNames, this.txtBox_className.Text))
            {
                MessageBox.Show("Třída s tímto názvem již existuje!");

                return false;
            }

            return true;
        }

        private List<string> GetPropertyNames()
        {
            List<string> propertyNames = new List<string>();
            foreach (ClassProperty property in this.listBox_properties.Items)
            {
                ClassProperty selectedProperty = (ClassProperty)this.listBox_properties.SelectedItem;
                if (selectedProperty == null || property.Name != selectedProperty.Name)
                {
                    propertyNames.Add(property.Name);
                }
            }

            return propertyNames;
        }
        
        private List<string> GetMethodNames()
        {
            List<string> methodNames = new List<string>();
            foreach (ClassMethod method in this.listBox_methods.Items)
            {
                ClassMethod selectedMethod = (ClassMethod)this.listBox_methods.SelectedItem;
                if (selectedMethod == null || method.Name != selectedMethod.Name)
                {
                    methodNames.Add(method.Name);
                }
            }

            return methodNames;
        }


    }
}
