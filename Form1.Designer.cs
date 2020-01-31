namespace Google_GAM_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            "",
            ""}, -1);
            this.fornavntextBox1 = new System.Windows.Forms.TextBox();
            this.efternavntextBox2 = new System.Windows.Forms.TextBox();
            this.upntextBox3 = new System.Windows.Forms.TextBox();
            this.domainlistBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Fornavn_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Efternavn_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UPN_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email_header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fornavntextBox1
            // 
            this.fornavntextBox1.Location = new System.Drawing.Point(12, 11);
            this.fornavntextBox1.Name = "fornavntextBox1";
            this.fornavntextBox1.Size = new System.Drawing.Size(142, 20);
            this.fornavntextBox1.TabIndex = 0;
            this.fornavntextBox1.Text = "Fornavn";
            // 
            // efternavntextBox2
            // 
            this.efternavntextBox2.Location = new System.Drawing.Point(160, 11);
            this.efternavntextBox2.Name = "efternavntextBox2";
            this.efternavntextBox2.Size = new System.Drawing.Size(154, 20);
            this.efternavntextBox2.TabIndex = 1;
            this.efternavntextBox2.Text = "Efternavn";
            // 
            // upntextBox3
            // 
            this.upntextBox3.Location = new System.Drawing.Point(320, 11);
            this.upntextBox3.Name = "upntextBox3";
            this.upntextBox3.Size = new System.Drawing.Size(154, 20);
            this.upntextBox3.TabIndex = 3;
            this.upntextBox3.Text = "UPN";
            // 
            // domainlistBox1
            // 
            this.domainlistBox1.FormattingEnabled = true;
            this.domainlistBox1.Items.AddRange(new object[] {
            "@dagrofa.dk",
            "@dagrofa-logistik.dk",
            "@dagrofa.net",
            "@dagrofaacademy.dk",
            "@dagrofabornholm.dk",
            "@dagrofahrudvikling.dk",
            "@dagrofakontraktflow.dk",
            "@dgfs.dk",
            "@dgfsystems.dk",
            "@dreisler.dk\t",
            "@foodservicedanmark.dk",
            "@gronbalance.dk",
            "@hkiost.dk",
            "@kiwi.dk",
            "@kiwidanmark.dk",
            "@kkengros.gl",
            "@kobmandshuset.dk",
            "@koedgrossisten.dk",
            "@letkob.net",
            "@meny.dk",
            "@merkurlive.dk",
            "@minkobmand.dk\t",
            "@naerkob.dk",
            "@norddata.dk",
            "@pgcd.dk",
            "@primafrugt.dk",
            "@qgcd.dk",
            "@soerwi.dk",
            "@spar.dk",
            "@superbest.dk",
            "@supergros.dk"});
            this.domainlistBox1.Location = new System.Drawing.Point(480, 11);
            this.domainlistBox1.Name = "domainlistBox1";
            this.domainlistBox1.Size = new System.Drawing.Size(128, 21);
            this.domainlistBox1.TabIndex = 4;
            this.domainlistBox1.Text = "Domæne";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(929, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tilføj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(821, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tilføj bruger til buffer";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Fornavn_header,
            this.Efternavn_header,
            this.UPN_header,
            this.Email_header});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(992, 197);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Fornavn_header
            // 
            this.Fornavn_header.Text = "Fornavn";
            this.Fornavn_header.Width = 175;
            // 
            // Efternavn_header
            // 
            this.Efternavn_header.Text = "Efternavn";
            this.Efternavn_header.Width = 166;
            // 
            // UPN_header
            // 
            this.UPN_header.Text = "UPN";
            this.UPN_header.Width = 187;
            // 
            // Email_header
            // 
            this.Email_header.Text = "E-mail";
            this.Email_header.Width = 237;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 253);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 82);
            this.listBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Tilføj brugere til GAM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.domainlistBox1);
            this.Controls.Add(this.upntextBox3);
            this.Controls.Add(this.efternavntextBox2);
            this.Controls.Add(this.fornavntextBox1);
            this.Name = "Form1";
            this.Text = "Google GAM App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fornavntextBox1;
        private System.Windows.Forms.TextBox efternavntextBox2;
        private System.Windows.Forms.TextBox upntextBox3;
        private System.Windows.Forms.ComboBox domainlistBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Fornavn_header;
        private System.Windows.Forms.ColumnHeader Efternavn_header;
        private System.Windows.Forms.ColumnHeader UPN_header;
        private System.Windows.Forms.ColumnHeader Email_header;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

