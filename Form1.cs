﻿using System;
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

            if (fornavntextBox1.Text == "")
            {
                MessageBox.Show("Fejl: Fornavn mangler.");
                return;
            }

            if (efternavntextBox2.Text == "")
            {
                MessageBox.Show("Fejl: Efternavn mangler.");
                return;
            }

            if (upntextBox3.Text == "")
            {
                MessageBox.Show("Fejl: UPN mangler.");
                return;
            }
            if (domainlistBox1.Text == "")
            {
                MessageBox.Show("Fejl: Domæne mangler.");
                return;
            }



            string[] arr = new string[4];

            arr[0] = fornavntextBox1.Text;
            arr[1] = efternavntextBox2.Text;
            arr[2] = upntextBox3.Text;
            arr[3] = upntextBox3.Text + domainlistBox1.Text;

            ListViewItem lvwItem = new ListViewItem(arr);

            listView1.Items.Add(lvwItem);

            fornavntextBox1.Clear();
            efternavntextBox2.Clear();
            upntextBox3.Clear();
            domainlistBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int ii = 1;
                ii++;

                Console.WriteLine(
                    "gam create user " + 
                    listView1.Items[i].SubItems[0].Text + " " + 
                    listView1.Items[i].SubItems[1].Text + " " + 
                    listView1.Items[i].SubItems[2].Text + " " + 
                    listView1.Items[i].SubItems[3].Text);

            }
        }

        //public string create_Users_With_GAM(string Fornavn, string Efternavn, String UPN, string domain)
        //{
        //    string create_user_string = string.Format("gam create user {0}", Fornavn);

        //    listView1


        //    return create_user_string;
        //}
    }
}

