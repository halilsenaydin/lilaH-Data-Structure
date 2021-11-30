using DataStructures.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class LilahInteger : Form
    {
        ILilah<int> _lilah;
        public LilahInteger()
        {
            InitializeComponent();
        }

        public LilahInteger(ILilah<int> lilah)
        {
            InitializeComponent();
            _lilah = lilah;
        }
    }
}
