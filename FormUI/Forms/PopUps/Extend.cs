using DataStructures.Abstracts;
using DataStructures.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms.PopUps
{
    public partial class Extend : Form
    {
        public Extend()
        {
            InitializeComponent();
        }

        ILilah<object> tempLilah = new Lilah<object>();
        ILilahList _lilah;
        public Extend(ILilahList lilah)
        {
            InitializeComponent();
            _lilah = lilah;
        }

        private void buttonAppendInteger_Click(object sender, EventArgs e)
        {
            var item = textBoxInput.Text;
            var result = tempLilah.Append(Convert.ToInt32(item));
            textBoxInput.Clear();

            if (result.Success)
            {
                MessageBox.Show("Tam Sayı Girişi Yapıldı");
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void buttonAppendString_Click(object sender, EventArgs e)
        {
            var item = textBoxInput.Text;
            var result = tempLilah.Append(item);
            textBoxInput.Clear();

            if (result.Success)
            {
                MessageBox.Show("Metin Girişi Yapıldı");
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void buttonAppendDigit_Click(object sender, EventArgs e)
        {
            var item = textBoxInput.Text;
            var result = tempLilah.Append(Convert.ToDouble(item));
            textBoxInput.Clear();

            if (result.Success)
            {
                MessageBox.Show("Ondalıklı Sayı Girişi Yapıldı");
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void buttonExtend_Click(object sender, EventArgs e)
        {
            _lilah.Extend(tempLilah);
            MessageBox.Show("Girilen Veriler Başarılı Bir Şekilde Eklendi!");
            tempLilah.RemoveAll();
        }
    }
}
