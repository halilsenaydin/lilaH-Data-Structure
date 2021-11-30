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
    public partial class Append : Form
    {
        public Append()
        {
            InitializeComponent();
        }

        ILilahList _lilah; // İşte bu yüzden interface'leri seviyorum :)
        // Bu sayede, gelen listeye direkt ekleme yapıyoruz, interface referans tutuyor..
        public Append(ILilahList lilah)
        {
            InitializeComponent();
            _lilah = lilah;
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            var item = textBoxInput.Text;
            var result =  _lilah.Append(item);
            textBoxInput.Clear();

            if (result.Success)
            {
                MessageBox.Show("Metin Başarılı Bir Şekilde Eklendi");
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void buttonAppendInteger_Click(object sender, EventArgs e)
        {
            var item = textBoxInput.Text;
            var result = _lilah.Append(Convert.ToInt32(item));
            textBoxInput.Clear();

            if (result.Success)
            {
                MessageBox.Show("Tam Sayı Başarılı Bir Şekilde Eklendi");
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void buttonAppendDigit_Click(object sender, EventArgs e)
        {
            var item = textBoxInput.Text;
            var result = _lilah.Append(Convert.ToDouble(item));
            textBoxInput.Clear();

            if (result.Success)
            {
                MessageBox.Show("Ondalıklı Sayı Başarılı Bir Şekilde Eklendi");
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
