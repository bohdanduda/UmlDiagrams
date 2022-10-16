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

            List<string> classesWithExistingRelationship = new();

            foreach (ClassRelationship relationship in this.RelationshipListBox.Items)
            {
                classesWithExistingRelationship.Add(relationship.RelatedClassName);
            }

            if (!addingNewRelationship)
            {
                ClassRelationship editedRelationship = this.RelationshipListBox.SelectedItem as ClassRelationship;
                classesWithExistingRelationship.Remove(editedRelationship.RelatedClassName);
            }

            foreach (string className in classNames)
            {
                if (!classesWithExistingRelationship.Contains(className))
                {
                    this.comboBox_ClassName.Items.Add(className);
                }
            }

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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (comboBox_Relationship.SelectedItem == null)
            {
                MessageBox.Show("Je třeba vybrat typ vztahu!");
                return;
            }

            if (comboBox_ClassName.SelectedItem == null)
            {
                MessageBox.Show("Je třeba vybrat cílovou třídu!");
                return;
            }

            if (this.AddingNewRelationship)
            {
                this.RelationshipListBox.Items.Add(new ClassRelationship
                {
                    Type = this.comboBox_Relationship.Text,
                    RelatedClassName = this.comboBox_ClassName.Text
                });
                 
                this.Close();

                return;
            }

            ClassRelationship selectedRelationship = this.RelationshipListBox.SelectedItem as ClassRelationship;
            selectedRelationship.Type = this.comboBox_Relationship.Text;
            selectedRelationship.RelatedClassName = this.comboBox_ClassName.Text;

            this.RefreshRelationshipListbox();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshRelationshipListbox()
        {
            List<ClassRelationship> relationships = new List<ClassRelationship>();
            foreach (ClassRelationship relationship in this.RelationshipListBox.Items)
            {
                relationships.Add(relationship);
            }

            this.RelationshipListBox.Items.Clear();

            foreach (ClassRelationship relationship in relationships)
            {
                this.RelationshipListBox.Items.Add(relationship);
            }
        }
    }
}
