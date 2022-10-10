using WinFormsApp6.Data;

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
                this.comboBox_accessModifier.SelectedIndex = this.comboBox_accessModifier.Items.IndexOf(selectedProperty.AccessModifier);
                this.comboBox_dataType.SelectedIndex = this.comboBox_dataType.Items.IndexOf(selectedProperty.DataType);
            }
            else
            {
                this.Text = "Přidání nové vlastnosti";
                this.Update();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (comboBox_accessModifier.SelectedItem == null)
            {
                MessageBox.Show("Je třeba vybrat modifikátor přístupu!");
                return;
            }

            if (comboBox_dataType.SelectedItem == null)
            {
                MessageBox.Show("Je třeba vybrat datový typ!");
                return;
            }

            if (txtBox_propertyName.Text.Trim() == "")
            {
                MessageBox.Show("Název vlastnosti nesmí být prázdný!");
                return;
            }

            if (this.addingNewProperty)
            {
                this.PropertyListBox.Items.Add(new ClassProperty()
                {
                    AccessModifier = this.comboBox_accessModifier.SelectedItem.ToString(),
                    DataType = this.comboBox_dataType.SelectedItem.ToString(),
                    Name = this.txtBox_propertyName.Text
                }
                );
                this.Close();

                return;
            }

            ClassProperty selectedProperty = this.PropertyListBox.SelectedItem as ClassProperty;
            selectedProperty.AccessModifier = this.comboBox_accessModifier.SelectedItem.ToString();
            selectedProperty.DataType = this.comboBox_dataType.SelectedItem.ToString();
            selectedProperty.Name = this.txtBox_propertyName.Text;

            this.RefreshPropertyListBox();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshPropertyListBox()
        {
            List<ClassProperty> properties = new List<ClassProperty>();
            foreach (ClassProperty property in this.PropertyListBox.Items)
            {
                properties.Add(property);
            }

            this.PropertyListBox.Items.Clear();

            foreach (ClassProperty property in properties)
            {
                this.PropertyListBox.Items.Add(property);
            }
        }
    }
}
