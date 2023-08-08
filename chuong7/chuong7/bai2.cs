using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace chuong7
{
    public partial class bai2 : Form
    {
        ArrayList arrEmploy = new ArrayList();
        public bai2()
        {
            InitializeComponent();
        }

        private void bai2_Load(object sender, EventArgs e)
        {

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Employee em = new Employee(txtName.Text, int.Parse(txtAge.Text), txtAdress.Text);
            arrEmploy.Add(em);
            Adress.Text = Age.Text = Name.Text = "";
            txtName.Focus();
        }
    }
}
