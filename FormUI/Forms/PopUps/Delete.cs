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
    public partial class Delete : Form
    {
        ILilahList _lilah;
        public Delete()
        {
            InitializeComponent();
        }
        public Delete(ILilahList lilah)
        {
            InitializeComponent();
            _lilah = lilah;
        }

        private void buttonDeleteByIndex_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBoxInput.Text);
            var result = _lilah.Remove(index);
            if (result.Success)
            {
                MessageBox.Show("Item Başarılı Bir Şekilde Kaldırıldı");
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            var result = _lilah.Remove(textBoxInput.Text);
            if (result.Success)
            {
                MessageBox.Show("Bulunan Item(ler) Başarılı Bir Şekilde Kaldırıldı");
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
