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
    public partial class LilahDouble : Form
    {

        ILilah<double> _lilah;
        public LilahDouble()
        {
            InitializeComponent();
        }

        public LilahDouble(ILilah<double> lilah)
        {
            InitializeComponent();
            _lilah = lilah;
        }
    }
}
