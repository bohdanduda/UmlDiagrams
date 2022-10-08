﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp6.Data;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        public ClassData ClassData { get; set; }
        public Form2(ClassData classData)
        {
            InitializeComponent();
            this.ClassData = classData;
            this.txtBox_className.Text = classData.ClassName;

            foreach (string propertyName in classData.Properties)
            {
                this.listBox_properties.Items.Add(propertyName);
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ClassData.ClassName = this.txtBox_className.Text;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
