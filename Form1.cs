using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_GAM_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            int userid = 0;

            ListViewItem lvwItem = listView1.Items.Add(userid.ToString());
            lvwItem.SubItems.Add(textBox1.Text);
            lvwItem.SubItems.Add(textBox2.Text);
            lvwItem.SubItems.Add(textBox3.Text);
        }

      
    }
}
