﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisi
{
    public partial class Kontrol2 : UserControl
    {
        public Kontrol2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Kaydedildi Lütfen Adres ve Telefon Girin");
        }
    }
}
