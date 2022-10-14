using WinFormsApp6.Data;

namespace WinFormsApp6.Forms
{
    public partial class RelationshipEditForm : Form
    {
        public ClassRelationship classRelationship = new();

        public RelationshipEditForm(List<string> classNames)
        {
            InitializeComponent();

            foreach (string className in classNames)
            {
                this.comboBox_ClassName.Items.Add(className);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
