using WinFormsApp6.Data;

namespace WinFormsApp6.Forms
{
    public partial class RelationshipEditForm : Form
    {
        public ClassRelationship classRelationship = new();
        public ListBox RelationshipListBox { get; set; }

        public List<string> ExistingClassNames = new();
        public bool AddingNewRelationship { get; set; }

        public RelationshipEditForm(List<string> classNames, ListBox relationshipListBox, bool addingNewRelationship)
        {
            InitializeComponent();

            this.comboBox_Relationship.Items.AddRange(new object[] {
                RelationshipType.ASSOCIATION,
                RelationshipType.INHERITANCE,
                RelationshipType.IMPLEMENTATION,
                RelationshipType.DEPENDENCY,
                RelationshipType.AGGREGATION,
                RelationshipType.COMPOSITION
            });

            this.RelationshipListBox = relationshipListBox;
            this.AddingNewRelationship = addingNewRelationship;

            if (!addingNewRelationship)
            {
                this.Text = "Upravení vztahu";

                ClassRelationship selectedRelationship = this.RelationshipListBox.SelectedItem as ClassRelationship;

                this.comboBox_Relationship.SelectedIndex = this.comboBox_Relationship.Items.IndexOf(selectedRelationship.Type);
                this.comboBox_ClassName.SelectedIndex = this.comboBox_ClassName.Items.IndexOf(selectedRelationship.RelatedClassName);
            }
            else
            {
                this.Text = "Přidání vztahu";
                this.Update();
            }

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
