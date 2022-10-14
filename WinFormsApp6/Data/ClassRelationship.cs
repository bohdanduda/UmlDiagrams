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
        public void AddRelationship(ComboBox comboBox)
        {
            comboBox.Items.Add("Závislost");
            comboBox.Items.Add("Asociace");
            comboBox.Items.Add("Agragace");
            comboBox.Items.Add("Kompozice");
            comboBox.Items.Add("Dědičnost");
            comboBox.Items.Add("Realizace");
        }
    }
}
