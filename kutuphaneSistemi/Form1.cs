﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ogrenci yeni = new Ogrenci();
            yeni.Show();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap ff = new Kitap();
            ff.Show();
        }

        private void btnKutuphane_Click(object sender, EventArgs e)
        {
            Kutuphane yeni = new Kutuphane();
            yeni.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciKitapListe yeni = new OgrenciKitapListe();
            yeni.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}