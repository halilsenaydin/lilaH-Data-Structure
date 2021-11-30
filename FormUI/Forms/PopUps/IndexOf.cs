using Core.Operations;
using Core.Operations.Abstracts;
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
    public partial class IndexOf : Form
    {
        ILilahList _lilah;
        IArrayOperationService _arrayOperation = new ArrayOperationManager();
        public IndexOf()
        {
            InitializeComponent();
        }

        public IndexOf(ILilahList lilah)
        {
            InitializeComponent();
            _lilah = lilah;
        }

        private void buttonIndexOf_Click(object sender, EventArgs e)
        {
            var item = textBoxInput.Text;
            var result = _lilah.IndexOf(item);
            if (result.Success)
            {
                MessageBox.Show(String.Format("İtem'in index Numarası; {0}", result.Data));
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
