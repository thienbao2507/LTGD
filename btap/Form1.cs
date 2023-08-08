using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tB1.Text == "")
            {
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(tB1.Text);
                tB1.Text = "";
                if (radioButton1.Checked)
                {
                    item.SubItems.Add("Nam");
                    item.ImageIndex = 0;
                }
                if (radioButton2.Checked)
                {
                    item.SubItems.Add("Nu");
                    item.ImageIndex = 1;
                }
                item.SubItems.Add(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                listView1.Items.Add(item);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lVI in listView1.SelectedItems)
            {
                listView1.Items.Remove(lVI);
            }


        }
    }
}
