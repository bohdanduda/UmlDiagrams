using WinFormsApp6.Data;

namespace WinFormsApp6.Forms
{
    public partial class RelationshipEditForm : Form
    {
        public ClassRelationship classRelationship = new();
        public ListBox RelationshipListBox { get; set; }

        public List<string> ExistingClassNames = new();


        public RelationshipEditForm(List<string> classNames, ListBox relationshipListBox)
        {
            InitializeComponent();

            this.RelationshipListBox = relationshipListBox;

            foreach (string className in classNames)
            {
                this.comboBox_ClassName.Items.Add(className);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.RelationshipListBox.Items.Add(new ClassRelationship
            {
                Type = this.comboBox_Relationship.Text,
                RelatedClassName = this.comboBox_ClassName.Text    
            });


            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
