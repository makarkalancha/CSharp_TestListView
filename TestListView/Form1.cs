using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = listView1.Items.Add(Microsoft.VisualBasic.Interaction.InputBox("Name:", "Please enter name", "name", 200, 200));
            newItem.SubItems.Add(Microsoft.VisualBasic.Interaction.InputBox("Age:", "Please enter age", "age", 200, 200));
            newItem.SubItems.Add(Microsoft.VisualBasic.Interaction.InputBox("City:", "Please enter city", "city", 200, 200));
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void butRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem toDelete in listView1.SelectedItems)
            {
                toDelete.Remove();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        } 
    }
}
