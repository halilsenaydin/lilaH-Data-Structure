using DataStructures.Abstracts;
using DataStructures.Concretes;
using FormUI.Forms.PopUps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class LilahList : Form
    {
        ILilahList _lilah = new DataStructures.Concretes.LilahList();
        public LilahList()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var form = new Update(_lilah);
            form.Show();
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            var form = new Append(_lilah);
            form.Show();
        }

        private void buttonAppendFromArray_Click(object sender, EventArgs e)
        {
            var form = new Extend(_lilah);
            form.Show();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            for (int i = 0; i < _lilah.Len; i++)
            {
                dataGrid.Rows.Add(new object[] { i, _lilah.array[i], _lilah.array[i].GetType().Name }) ;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            var form = new Find(_lilah);
            form.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var form = new Delete(_lilah);
            form.Show();
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            _lilah.RemoveAll();
        }

        private void buttonIndexOf_Click(object sender, EventArgs e)
        {
            var form = new IndexOf(_lilah);
            form.Show();
        }

        private void buttonGoHome_Click(object sender, EventArgs e)
        {
            var form = new Home();
            form.Show();
            this.Hide();
        }
    }
}
