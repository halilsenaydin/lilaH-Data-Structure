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
    public partial class LilahString : Form
    {
        ILilah<string> _lilah;
        public LilahString()
        {
            InitializeComponent();
        }

        public LilahString(ILilah<string> lilah)
        {
            InitializeComponent();
            _lilah = lilah;
        }
    }
}
