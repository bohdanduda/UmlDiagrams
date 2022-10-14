using WinFormsApp6.Data;

namespace WinFormsApp6
{
    public partial class MethodEditForm : Form
    {
        private bool addingNewMethod { get; set; }
        public ListBox MethodListBox { get; set; }
        public MethodEditForm(ListBox methodListBox, bool addingNewMethod)
        {
            this.addingNewMethod = addingNewMethod;
            MethodListBox = methodListBox;
            InitializeComponent();
            if (!addingNewMethod)
            {
                ClassMethod selectedMethod = this.MethodListBox.SelectedItem as ClassMethod;
                this.txtBox_methodName.Text = selectedMethod.Name;
                this.comboBox_accessModifier.SelectedIndex = this.comboBox_accessModifier.Items.IndexOf(selectedMethod.AccessModifier);
                this.comboBox_dataType.SelectedIndex = this.comboBox_dataType.Items.IndexOf(selectedMethod.DataType);
            }
            else
            {
                this.Text = "Přidání nové metody";
                this.Update();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!this.CheckMethodName())
            {
                return;
            }

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

            if (txtBox_methodName.Text.Trim() == "")
            {
                MessageBox.Show("Název metody nesmí být prázdný!");
                return;
            }

            if (this.addingNewMethod)
            {
                this.MethodListBox.Items.Add(new ClassMethod()
                {
                    AccessModifier = this.comboBox_accessModifier.SelectedItem.ToString(),
                    DataType = this.comboBox_dataType.SelectedItem.ToString(),
                    Name = this.txtBox_methodName.Text,
                });
                this.Close();

                return;
            }

            ClassMethod selectedMethod = this.MethodListBox.SelectedItem as ClassMethod;
            selectedMethod.AccessModifier = this.comboBox_accessModifier.SelectedItem.ToString();
            selectedMethod.DataType = this.comboBox_dataType.SelectedItem.ToString();
            selectedMethod.Name = this.txtBox_methodName.Text;

            this.RefreshMethodListBox();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshMethodListBox()
        {
            List<ClassMethod> methods = new List<ClassMethod>();
            foreach (ClassMethod method in this.MethodListBox.Items)
            {
                methods.Add(method);
            }

            this.MethodListBox.Items.Clear();

            foreach (ClassMethod method in methods)
            {
                this.MethodListBox.Items.Add(method);
            }
        }

        private bool CheckMethodName()
        {
            TextValidator textValidator = new();

            //textValidator.Validate();

            if (!textValidator.ValidateText(this.txtBox_methodName.Text))
            {
                MessageBox.Show("Neplatný název metody!");

                return false;
            }

            return true;
        }
    }
}
