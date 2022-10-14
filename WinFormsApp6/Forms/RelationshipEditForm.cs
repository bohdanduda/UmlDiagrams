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
using WinFormsApp6.UMLDiagram;

namespace WinFormsApp6.Forms
{
    public partial class RelationshipEditForm : Form
    {
        public ClassRelationship classRelationship = new();
        
        public RelationshipEditForm()
        {
            InitializeComponent();

            this.Text = "Editace vztahu";
            classRelationship.AddRelationship(this.comboBox_Relationship);
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
