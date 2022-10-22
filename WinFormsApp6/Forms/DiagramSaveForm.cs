using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6.Forms
{
    public partial class DiagramSaveForm : Form
    {
        public string[] Lines = { "Evžen", "Lakatoš", "Hugo", "Demeter", "Gadžo" };
        public bool IsSaving;
        public DiagramSaveForm(bool isSaving)
        {
            IsSaving = isSaving;
            InitializeComponent();

            if (!IsSaving)
            {
                this.btn_Save.Text = "NAČÍST";
            }
        }

        private void btn_OpenExplorer_Click(object sender, EventArgs e)
        {
            if (this.IsSaving)
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { Description = "Vyber cestu pro uložení." })
                {
                    folderBrowser.ShowDialog();
                    this.txtBox_PathName.Text = folderBrowser.SelectedPath.ToString();
                }
            }

            if (!this.IsSaving)
            {
                using (OpenFileDialog openfileDialog = new OpenFileDialog())
                {
                    if (openfileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.txtBox_PathName.Text = openfileDialog.FileName.ToString();
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.IsSaving)
            {
                using (StreamWriter streamWriter = new StreamWriter(Path.Combine(this.txtBox_PathName.Text, "testFile.txt")))
                {
                    foreach (string line in this.Lines)
                    {
                        streamWriter.WriteLine(line);
                    }
                }
            }

            if (!this.IsSaving)
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(this.txtBox_PathName.Text))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            MessageBox.Show(line);
                        }
                    }
                }
                catch (Exception exeption)
                {
                    MessageBox.Show($"Textový soubor nemohl být načten.{Environment.NewLine} Chyba: {exeption}");   
                }
            }
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
