using DataStructures.Abstracts;
using DataStructures.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hocam istenilen method'ları yazdım. Core katmanında Operations klasöründen inceleyebilirsiniz. UI için eklemek istediğim çoğu şey yetişmedi :..(");
        }

        private void buttonCreateLilah_Click(object sender, EventArgs e)
        {
            LilahList form = new LilahList();
            this.Hide();
            GC.Collect();
            form.Show();
        }

        private void buttonInteger_Click(object sender, EventArgs e)
        {
            ILilah<int> dataStructure = new Lilah<int>();
            LilahInteger form = new LilahInteger(dataStructure);
            this.Hide();
            GC.Collect();
            form.Show();
        }

        private void buttonDouble_Click(object sender, EventArgs e)
        {
            ILilah<double> dataStructure = new Lilah<double>();
            LilahDouble form = new LilahDouble(dataStructure);
            this.Hide();
            GC.Collect();
            form.Show();
        }

        private void buttonString_Click(object sender, EventArgs e)
        {
            ILilah<string> dataStructure = new Lilah<string>();
            LilahString form = new LilahString(dataStructure);
            this.Hide();
            GC.Collect();
            form.Show();
        }
    }
}
