using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPersonelEkleSil_Click(object sender, EventArgs e)
        {
            PersonelEkleSil eklesil = new PersonelEkleSil();
            eklesil.Show();
            this.Hide();
        }

        private void btnPersGoruntule_Click(object sender, EventArgs e)
        {
            Personeller personel = new Personeller();
            personel.Show();
            
        }

        private void btnProje_Click(object sender, EventArgs e)
        {
            ProjeSayfasi proje = new ProjeSayfasi();
            proje.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MaaşBilgileri maas = new MaaşBilgileri();
            maas.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Close();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            anasayfaTarihSaat.Text = DateTime.Now.ToLongDateString();
        }

        private void anasayfaTarihSaat_Click(object sender, EventArgs e)
        {

        }
    }
}
