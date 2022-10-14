using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp6.Forms;
using WinFormsApp6.UMLDiagram;

namespace WinFormsApp6.Data
{
    public class ClassRelationship
    {
        public void AddRelationship(ComboBox comboBox_Relationship)
        {
            comboBox_Relationship.Items.Add("Závislost");
            comboBox_Relationship.Items.Add("Asociace");
            comboBox_Relationship.Items.Add("Agregace");
            comboBox_Relationship.Items.Add("Kompozice");
            comboBox_Relationship.Items.Add("Dědičnost");
            comboBox_Relationship.Items.Add("Realizace");
        }
    }
}
