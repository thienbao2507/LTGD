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
namespace chuong7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();
        }

        private void InitTree()
        {
            string[] drivers = Directory.GetLogicalDrives();

            TreeNode node = null;
            foreach (string drv in drivers)
            {
                node = new TreeNode(drv);
                treeFolder.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;//node dugc chon
            node.Nodes.Clear();//x6a céc node con (node Temp)
            node.ImageIndex = 1;
            //load danh séch caéc thu myc con
            try
            {//duyét qua cdc thu myc con
                foreach (string dir in Directory.GetDirectories(node.FullPath))
                {//thém cdc thu myc con vao tap nodes cla node hién tai
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("Temp");

                }

            }
            catch { }
        }

        private void treeFolder_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }
    }
}
