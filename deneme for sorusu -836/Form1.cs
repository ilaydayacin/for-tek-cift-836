﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_for_sorusu__836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSinir.Text);
            for (int i = 0; i < sayi; i++)
            {
                if (i % 2 == 0)
                {
                    lbÇift.Items.Add(i);

                }
                else
                {
                    lbTek.Items.Add(i);
                }
            }
        }
    }
}
