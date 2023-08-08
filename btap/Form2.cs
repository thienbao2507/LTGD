using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace btap
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string text;
        private void btRead_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Chọn file";
            //openFileDialog.Filter = "Tất cả các tệp tin (*.*)|*.*";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string filePath = openFileDialog.FileName;

            //    try
            //    {
            //        Process.Start(filePath);
            //    }
            //    catch (FileNotFoundException ex)
            //    {

            //    }
            //}
            StreamReader doc = new StreamReader(@"C:\muckhac\Learning\bai2.txt");
            do
            {
                text = doc.ReadLine();

            } while (text != null);
            richTextBox1.Text = text;
        }
        
    }
}
