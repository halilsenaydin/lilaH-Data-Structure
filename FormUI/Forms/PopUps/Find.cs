using DataStructures.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms.PopUps
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        ILilahList _lilah;
        public Find(ILilahList lilah)
        {
            InitializeComponent();
            _lilah = lilah;
        }

        private void buttonFindByIndex_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            var index = Convert.ToInt32(textBoxInput.Text);
            var result =  _lilah.Find(index);
            dataGrid.Rows.Add(index, result, result.GetType().Name);
        }

        private void buttonFindByItem_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            var index = textBoxInput.Text;
            var result = _lilah.Find(index);
            if (result.Len == 0)
            {
                MessageBox.Show("Veri Bulunamadı");
            }
            else
            {
                dataGrid.Rows.Add(result.array[0], result.array[1], result.array[1].GetType().Name);
            }
        }
    }
}
