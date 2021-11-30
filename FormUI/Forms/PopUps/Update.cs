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
    public partial class Update : Form
    {
        ILilahList _lilah;
        public Update()
        {
            InitializeComponent();
        }

        public Update(ILilahList lilah)
        {
            InitializeComponent();
            _lilah = lilah;
            ShowData();
        }

        private void ShowData()
        {
            dataGrid.Rows.Clear();
            for (int i = 0; i < _lilah.Len; i++)
            {
                dataGrid.Rows.Add(new object[] { 0, _lilah.array[i], _lilah.array[i].GetType().Name });
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBoxIndex.Text);
            var value = textBoxSet.Text;

            var result = _lilah.Update(index, value);
            if (result.Success)
            {
                MessageBox.Show("Güncelleme Başarılı");
                ShowData();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
